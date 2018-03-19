using System.Collections.Generic;

namespace Models.RpgStoryStart
{
    /// <summary>
    /// Dialog for Story
    /// </summary>
    public class Dialog
    {
        public int DialogId { get; set; }
        public List<ConversationModel> Conversations { get; set; } = new List<ConversationModel>();
    }
}
