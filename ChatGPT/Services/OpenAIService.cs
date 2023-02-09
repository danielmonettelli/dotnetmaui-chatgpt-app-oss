using ChatGPT.Constants;
using ChatGPT.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace ChatGPT.Services
{
    public class OpenAIService : IOpenAIService
    {
        HttpClient client;
        JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true };

        public OpenAIService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(APIConstants.OpenAIUrl);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIConstants.OpenAIToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> AskQuestion(string query)
        {
            var completion = new CompletionRequest()
            {
                Prompt = query
            };

            var body = JsonSerializer.Serialize(completion);
            var content = new StringContent(body, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(APIConstants.OpenAIEndpoint_Completions, content);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<CompletionResponse>(options);
                return data?.Choices?.FirstOrDefault().Text;
            }

            return default;
        }

        public async Task<string> CreateImage(string query)
        {
            var generation = new GenerationRequest()
            {
                Prompt = query
            };

            var body = JsonSerializer.Serialize(generation);
            var content = new StringContent(body, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(APIConstants.OpenAIEndpoint_Generations, content);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<GenerationResponse>(options);
                return data.Data?.FirstOrDefault()?.Url;
            }

            return default;
        }
    }
}
