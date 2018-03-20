using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class StoryEntity
    {
        [Key]
        public int StoryId { get; set; }
        public string StoryTitle { get; set; }
    }
}