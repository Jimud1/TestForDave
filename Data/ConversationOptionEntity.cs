using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class ConversationOptionEntity
    {
        [Key]
        public int ConversationOptionId { get; set; }
        public int ConversationId { get; set; }
        public string ConversationOptionText { get; set; }
    }
}