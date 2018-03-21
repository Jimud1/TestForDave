using System.Collections.Generic;
using System.Linq;
using DataLayer;

namespace BusinessLogic.ConversationService
{
    public class ConversationOptionsService : IConversationOptionsService
    {
        private readonly IRespository _respository;

        public ConversationOptionsService()
        {
            _respository = new Repository();
        }

        public ConversationOptionEntity Add(ConversationOptionEntity model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ConversationOptionEntity Update(int id, ConversationOptionEntity model)
        {
            throw new System.NotImplementedException();
        }

        public ConversationOptionEntity Get()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> GetByConversationId(int conversationId)
        {
            var conversationOptions = _respository.StoryContext.ConversationOption.Where(x => x.ConversationId == conversationId);
            var stringOptions = new List<string>();

            foreach (var option in conversationOptions)
            {
                stringOptions.Add(option.ConversationOptionText);
            }

            return stringOptions;
        }

        public ConversationOptionEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}