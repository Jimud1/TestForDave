using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class ConversationEntity
    {
        [Key]
        public int ConversationId { get; set; }
        public int StoryId { get; set; }
        public string ConversationText { get; set; }
        public int? LeadToStoryId { get; set; }
    }
}