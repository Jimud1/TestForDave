using System.Collections.Generic;

namespace Models.RpgStoryStart
{
    /// <summary>
    /// Story start
    /// </summary>
    public class StoryModel : IModel
    {
        public int StoryId { get; set; }
        public string Title { get; set; }
        public List<ConversationModel> Conversations { get; set; } = new List<ConversationModel>();
    }
}
