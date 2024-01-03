using ChatApp.Data.Entities.Models;
using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Repositories
{
    public class GroupRepository : BaseRepository
    {
        public GroupRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType AddGroup(Group group)
        {
            DbContext.Groups.Add(group);
            return SaveChanges();
        }

        public List<Group>? GetAllUnjoinedGroups(User user)
        {
            var groups = DbContext.Groups
                .Where(g => !g.GroupUsers.Any(gu => gu.UserId == user.Id))
                .ToList();

            if (groups == null)
                return null;

            return groups;
        }

        public List<Group>? GetAllJoinedGroups(User user)
        {
            var groups = DbContext.Groups
                              .Where(g => g.GroupUsers.Any(gu => gu.UserId == user.Id))
                              .ToList();

            if (groups == null)
                return null;

            return groups;
        }
    }
}
