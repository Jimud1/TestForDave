namespace DataLayer
{
    public class Repository : IRespository
    {
        private StoryDummyContext _storyDummyContext;

        public StoryDummyContext StoryDummyContext => _storyDummyContext ?? (_storyDummyContext = new StoryDummyContext());
    }
}