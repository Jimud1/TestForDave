using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models.RpgStoryStart
{
    /// <summary>
    ///Conversation for Dialog
    /// </summary>
    public class ConversationModel
    {
        [JsonProperty("conversation_id")]
        public int ConversationId { get; set; }

        [JsonProperty("conversation_text")]
        public string Conversation { get; set; }

        [JsonProperty("conversation_options")]
        public IList<string> ConversationOptions { get; set; } = new List<string>();

        [JsonProperty("story_lead_id")]
        public int? StoryLeadId { get; set; }
    }
}
