using System;
using System.Linq;
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

        public Story Add(Story model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Story Update(int id, Story model)
        {
            throw new System.NotImplementedException();
        }

        public Story Get()
        {
            throw new System.NotImplementedException();
        }


        private bool StoryLeadCheck(Story story, int id)
        {
            return story.StoryLeads.Contains(id);
        }

        public Story Get(int id)
        {
            /*This is the main function I will care about at the moment, that will deliver the given story depending on */
            try
            {
                var story = _respository.StoryDummyContext.Stories(id).FirstOrDefault();

                if (id > 1)
                {
                    //Check to see if the leading stories are valid
                    if (StoryLeadCheck(story, id))
                    {
                        throw new Exception($"{id} does not belong to Story with Id {story?.Id}");
                    }
                }

                return story;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured trying to get story", ex);
            }
        }
    }
}