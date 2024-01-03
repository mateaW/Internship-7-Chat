namespace ChatApp.Data.Entities.Models
{
    public class Group
    {
        public Group(string groupName)
        {
            GroupName = groupName;
        }

        public int Id { get; set; }

        public string GroupName { get; set; }

        public ICollection<GroupUser> GroupUsers { get; set; } = new List<GroupUser>();

        public ICollection<GroupMessage> GroupMessages { get; set; } = new List<GroupMessage>();
    }
}
