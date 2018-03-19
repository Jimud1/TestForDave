using System.Collections.Generic;

namespace Models.RpgStoryStart
{
    /// <summary>
    /// Story start
    /// </summary>
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public  List<Dialog> Dialogs { get; set; } = new List<Dialog>();
    }
}
