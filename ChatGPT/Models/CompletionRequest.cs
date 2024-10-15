using System.Text.Json.Serialization;

namespace ChatGPT.Models;

public class CompletionRequest
{
    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("messages")]
    public List<MessageRequest> Messages { get; set; }
}

public class MessageRequest
{
    [JsonPropertyName("role")]
    public string Role { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }
}