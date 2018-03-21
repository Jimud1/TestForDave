using System.Collections.Generic;
using DataLayer;

namespace BusinessLogic.ConversationService
{
    public interface IConversationOptionsService : IService<ConversationOptionEntity>
    {
        IEnumerable<string> GetByConversationId(int conversationId);
    }
}