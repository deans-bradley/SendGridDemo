namespace SendGridDemo
{
    public class Email
    {
        public string From { get; set; } = String.Empty;
        public string FromName { get; set; } = String.Empty;
        public string To { get; set; } = String.Empty;
        public string ToName { get; set; } = String.Empty;
        public string Subject { get; set; } = String.Empty;
        public string Body { get; set; } = String.Empty;
    }
}