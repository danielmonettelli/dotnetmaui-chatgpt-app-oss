namespace ChatGPT.Models
{
	public class CompletionResponse
	{
		public string Id { get; set; }
		public List<Choice> Choices { get; set; }
	}
}
