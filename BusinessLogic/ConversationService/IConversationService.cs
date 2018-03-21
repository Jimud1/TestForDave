using System.Collections.Generic;
using Models.RpgStoryStart;

namespace BusinessLogic.ConversationService
{
    public interface IConversationService : IService<ConversationModel>
    {
        IEnumerable<ConversationModel> GetConversationByStoryId(int storyId);
    }
}