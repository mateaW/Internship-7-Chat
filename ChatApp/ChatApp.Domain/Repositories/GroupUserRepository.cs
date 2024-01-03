using ChatApp.Data.Entities.Models;
using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Repositories
{
    public class GroupUserRepository : BaseRepository
    {
        public GroupUserRepository(ChatAppDbContext dbContext) : base(dbContext)
        {

        }

        public ResponseResultType AddUser(int userId, int groupId)
        {
            var group = DbContext.Groups.Find(groupId);
            if (group is null)
            {
                return ResponseResultType.NotFound;
            }

            var groupUser = new GroupUser
            {
                UserId = userId,
                GroupId = groupId
            };

            DbContext.GroupUsers.Add(groupUser);
            return SaveChanges();
        }
    }
}
