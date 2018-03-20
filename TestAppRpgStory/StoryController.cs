using BusinessLogic.StoryService;
using Models.RpgStoryStart;

namespace TestAppRpgStory
{
    public class StoryController
    {
        private readonly IStoryService _storyService;

        public StoryController()
        {
            _storyService = new StoryService();
        }

        public StoryModel GetStory(int id)
        {
            return _storyService.Get(id);
        }
    }
}