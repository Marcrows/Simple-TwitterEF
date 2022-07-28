using Microsoft.EntityFrameworkCore;
using TwitterEF.Models;

namespace Twitter.Context
{
    public class TwitterContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}