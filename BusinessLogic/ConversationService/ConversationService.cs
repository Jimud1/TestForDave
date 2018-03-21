using System.Collections.Generic;
using System.Linq;
using DataLayer;
using Models.RpgStoryStart;
using System;

namespace BusinessLogic.ConversationService
{
    public class ConversationService : IConversationService
    {
        private readonly IRespository _respository;
        private readonly IConversationOptionsService _conversationOptionsService;

        public ConversationService()
        {
            _respository = new Repository();
            _conversationOptionsService = new ConversationOptionsService();
        }

        public ConversationModel Add(ConversationModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ConversationModel Update(int id, ConversationModel model)
        {
            throw new System.NotImplementedException();
        }

        public ConversationModel Get()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ConversationModel> GetConversationByStoryId(int storyId)
        {
            var conversations = _respository.StoryContext.Conversation.Where(x => x.StoryId == storyId);
            var conversationModels = new List<ConversationModel>();

            foreach (var conversation in conversations)
            {
                conversationModels.Add(EntityToModel(conversation));
            }

            return conversationModels;
        }

        public ConversationModel Get(int id)
        {
            throw new NotImplementedException();
        }

        private ConversationModel EntityToModel(ConversationEntity entity)
        {
            var model = new ConversationModel
            {
                ConversationId = entity.ConversationId,
                Conversation = entity.ConversationText,
                ConversationOptions = _conversationOptionsService.GetByConversationId(entity.ConversationId).ToList()
            };

            if (entity.LeadToStoryId != null)
                model.StoryLeadId = entity.LeadToStoryId;

            return model;
        }

        private ConversationEntity ModelToEntity()
        {
            throw new NotImplementedException();
        }
    }
}