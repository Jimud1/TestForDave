using Microsoft.EntityFrameworkCore;
using Settings;

namespace DataLayer
{
    public class StoryContext : DbContext
    {
        public DbSet<StoryEntity> Story { get; set; }
        public DbSet<ConversationEntity> Conversation { get; set; }
        public DbSet<ConversationOptionEntity> ConversationOption { get; set; }
        /// <summary>
        /// Use this instead of constructor due to console application
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(RpgStoryConfig.LocalConnectionString);
        }
    }
}