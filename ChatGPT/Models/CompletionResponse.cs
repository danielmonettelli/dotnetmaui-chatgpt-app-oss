namespace ChatGPT.Models;

public class CompletionResponse
{
    public string Id { get; set; }

    public List<Choice> Choices { get; set; }

    public Usage Usage { get; set; }
}

public class Usage
{
    public int Prompt_Tokens { get; set; } = 9;

    public int Completion_Tokens { get; set; } = 12;

    public int Total_Tokens { get; set; } = 21;
}