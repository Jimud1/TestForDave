using System;
using DataLayer;
using Models.RpgStoryStart;

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


        public StoryModel Get(int id)
        {
            /*This is the main function I will care about at the moment, that will deliver the given story depending on */
            try
            {
                var story = _respository.StoryContext.Story.Find(id);

                return EntityToModel(story);
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