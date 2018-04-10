using BusinessLogic.ConversationService;
using DataLayer;
using Models.RpgStoryStart;
using System;
using System.Linq;
using Utilities;

namespace BusinessLogic.StoryService
{
    public class StoryService : IStoryService
    {
        private readonly IRespository _respository;

        public StoryService()
        {
            _respository = new Repository();
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

        public StoryModel Get(string filePath)
        {
            try
            {
                var json = _respository.JsonDataContext.GetJsonFromFile(filePath);
                var model = JsonModelHelper.JsonToModel<StoryModel>(json);
                return model;
            }
            catch(Exception ex)
            {
                throw new Exception($"An error occured getting {filePath}", ex);
            }

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
                Title = entity.StoryTitle
            };
            return model;
        }
    }
}