namespace DataLayer
{
    public class Repository : IRespository
    {
        private StoryContext _storyContext;

        public StoryContext StoryContext => _storyContext ?? (_storyContext = new StoryContext());
    }
}