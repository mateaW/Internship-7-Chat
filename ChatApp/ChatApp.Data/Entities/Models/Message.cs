namespace ChatApp.Data.Entities.Models
{
    public class Message
    {
        public Message(int senderId, int receiverId, string messageText)
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            MessageText = messageText;
            Date = DateTime.Now;
        }

        public int Id { get; set; }

        public int SenderId { get; set; }

        public User Sender { get; set; } = null!;

        public int ReceiverId { get; set; }

        public User Receiver { get; set; } = null!;

        public string MessageText { get; set; }

        public DateTime Date { get; set; }
    }
}
