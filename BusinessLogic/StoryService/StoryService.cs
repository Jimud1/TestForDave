using BusinessLogic.ConversationService;
using DataLayer;
using Models.RpgStoryStart;
using System;
using System.Linq;


namespace BusinessLogic.StoryService
{
    public class StoryService : IStoryService
    {
        private readonly IRespository _respository;
        private readonly IConversationService _conversationService;

        public StoryService()
        {
            _respository = new Repository();
            _conversationService = new ConversationService.ConversationService();
        }

        #region Basic CRUD - Not needed atm

        public IRespository Respository;

        public StoryModel Add(StoryModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public StoryModel Update(int id, StoryModel model)
        {
            throw new System.NotImplementedException();
        }

        public StoryModel Get()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        private StoryEntity ModelToEntity(StoryModel model)
        {
            throw new NotImplementedException();
        }


        public StoryModel Get(int id)
        {
            /*This is the main function I will care about at the moment, that will deliver the given story depending on */
            try
            {
                var storyEntity = _respository.StoryContext.Story.Find(id);

                if(storyEntity == null) throw new NullReferenceException($"Story with Id: {id} does not exist");

                var storyModel = EntityToModel(storyEntity);
                return storyModel;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured trying to get story", ex);
            }
        }

        private StoryModel EntityToModel(StoryEntity entity)
        {
            var model = new StoryModel
            {
                StoryId = entity.StoryId,
                Title = entity.StoryTitle,
                Conversations = _conversationService.GetConversationByStoryId(entity.StoryId).ToList()
            };
            return model;
        }
    }
}