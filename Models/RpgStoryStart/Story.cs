using System.Collections.Generic;

namespace Models.RpgStoryStart
{
    /// <summary>
    /// Story start
    /// </summary>
    public class Story : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ConversationModel> Conversations { get; set; } = new List<ConversationModel>();
        public List<int> StoryLeads { get; set; } = new List<int>();
    }
}
