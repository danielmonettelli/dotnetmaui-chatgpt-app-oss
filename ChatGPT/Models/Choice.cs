namespace ChatGPT.Models;

public class Choice
{
    public Message Message { get; set; }
}

public class Message
{
    public string Role { get; set; } = "assistant";

    public string Content { get; set; }
}