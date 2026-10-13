namespace MyAcademy_PortfolioProject.Entities
{
    public class Message
    {
        public int MessageId { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string Subject { get; set; }

        public string MessageContent { get; set; }

        public DateTime SentDate { get; set; }

        public bool IsRead { get; set; }

    }
}
