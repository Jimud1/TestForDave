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

        public ConversationOptionEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}