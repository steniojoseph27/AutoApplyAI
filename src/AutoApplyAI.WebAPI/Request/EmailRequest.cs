namespace AutoApplyAI.WebAPI.Request
{
    public class EmailRequest
    {
        public string RecipientEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string MessageBody { get; set; } = string.Empty;
    }
}
