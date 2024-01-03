using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using ChatApp.Data.Entities.Models;

namespace ChatApp.Domain.Repositories
{
    public class MessageRepository : BaseRepository
    {
        public MessageRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int senderId, int receiverId, string messageText)
        {
            var sender = DbContext.Users.Find(senderId);
            var receiver = DbContext.Users.Find(receiverId);
            if (sender is null || receiver is null)
            {
                return ResponseResultType.NotFound;
            }

            var message = new Message(senderId, receiverId, messageText);
            DbContext.Messages.Add(message);
            return SaveChanges();
        }

        public List<Message>? GetAll(int senderId, int receiverId)
        {
            var messages = DbContext.Messages
                .Include(m => m.Sender)
                .Where(m => (m.SenderId == senderId && m.ReceiverId == receiverId)
                          || (m.SenderId == receiverId && m.ReceiverId == senderId))
                .OrderBy(pm => pm.Date)
                .ToList();
            return messages;
        }
    }
}
