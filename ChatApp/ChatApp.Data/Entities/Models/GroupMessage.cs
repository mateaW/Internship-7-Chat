namespace ChatApp.Data.Entities.Models
{
    public class GroupMessage
    {
        public GroupMessage(int groupId, int senderId, string messageText)
        {
            GroupId = groupId;
            SenderId = senderId;
            MessageText = messageText;
            Date = DateTime.Now;
        }

        public int Id { get; set; }
        public int GroupId { get; set; }

        public Group Group { get; set; } = null!;

        public int SenderId { get; set; }

        public User Sender { get; set; } = null!;

        public string MessageText { get; set; }

        public DateTime Date { get; set; }
    }
}
