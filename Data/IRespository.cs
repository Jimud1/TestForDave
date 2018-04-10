namespace DataLayer
{
    public interface IRespository
    {
        StoryContext StoryContext { get; }

        JsonDataContext JsonDataContext { get; }
    }
}