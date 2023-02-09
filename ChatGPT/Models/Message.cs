namespace ChatGPT.Models
{
    public class Message
    {
        public string Text { get; set; }
        public bool IsUserMessage { get; set; }
        public bool IsTextActive { get; set; }
        public bool IsImageActive { get; set; }
    }
}
