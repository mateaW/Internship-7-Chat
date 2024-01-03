using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ChatApp.Data.Entities;

namespace ChatApp.Domain.Factories
{
    public static class DbContextFactory
    {
        public static ChatAppDbContext GetChatAppDbContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseNpgsql(ConfigurationManager.ConnectionStrings["ChatApp"].ConnectionString)
                .Options;

            return new ChatAppDbContext(options);
        }
    }
}
