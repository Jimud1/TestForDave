using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.RpgStoryStart
{
    /// <summary>
    /// Story start
    /// </summary>
    public class StoryModel : IModel
    {
        [JsonProperty("story_id")]
        public int StoryId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public IList<ConversationModel> Conversations { get; set; } = new List<ConversationModel>();
    }
}
