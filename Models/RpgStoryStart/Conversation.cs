using System.Collections.Generic;

namespace Models.RpgStoryStart
{
    /// <summary>
    ///Conversation for Dialog
    /// </summary>
    public class ConversationModel
    {
        public int ConversationId { get; set; }
        public string Conversation { get; set; }
        public List<string> ConversationOptions { get; set; } = new List<string>();
        public bool LeadingToStory { get; set; }
        public int? StoryLeadId { get; set; }
    }
}
