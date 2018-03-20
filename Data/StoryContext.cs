using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class StoryContext : DbContext
    {
        public StoryContext()
        {

        }
        public DbSet<StoryEntity> Story { get; set; }
        public DbSet<ConversationEntity> Conversation { get; set; }
        public DbSet<ConversationOptionEntity> ConversationOption { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestStories;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}