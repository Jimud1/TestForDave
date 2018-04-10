using Models.RpgStoryStart;

namespace BusinessLogic.StoryService
{
    public interface IStoryService : IService<StoryModel>
    {
        StoryModel Get(string filePath);
    }
}