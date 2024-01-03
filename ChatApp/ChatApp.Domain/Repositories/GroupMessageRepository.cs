using ChatApp.Data.Entities.Models;
using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Domain.Repositories
{
    public class GroupMessageRepository : BaseRepository
    {
        public GroupMessageRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(GroupMessage groupMessage)
        {
            DbContext.GroupMessages.Add(groupMessage);

            return SaveChanges();
        }

        public List<GroupMessage>? GetAll(int groupId)
        {
            var groupMessages = DbContext.GroupMessages
                .Include(gm => gm.Sender)
                .Where(gm => gm.GroupId == groupId)
                .OrderBy(gm => gm.Date)
                .ToList();

            if (groupMessages == null)
                return null;

            return groupMessages;
        }
    }
}
