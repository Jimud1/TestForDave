using DataLayer;
using System.Collections.Generic;
using Models.RpgStoryStart;

namespace BusinessLogic.StoryService
{
    public class StoryService : IStoryService
    {
        private readonly IRespository _respository;

        public StoryService(IRespository repository)
        {
            _respository = repository;
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

        public Story Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}