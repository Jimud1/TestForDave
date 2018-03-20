using System.Linq;
using DataLayer;
using Models.RpgStoryStart;

namespace TestAppRpgStory
{
    public class StoryController
    {
        private readonly StoryDummyContext _dummyContext;

        public StoryController()
        {
            _dummyContext = new StoryDummyContext();
        }

        public Story GetStory(int id)
        {
            return _dummyContext.Stories(id).FirstOrDefault();
        }
    }
}