namespace DataLayer
{
    public class Repository : IRespository
    {
        private StoryContext _storyContext;

        public StoryContext StoryContext => _storyContext ?? (_storyContext = new StoryContext());

        private JsonDataContext _jsonDataContext;

        public JsonDataContext JsonDataContext => _jsonDataContext ?? (_jsonDataContext = new JsonDataContext());
    }
}
