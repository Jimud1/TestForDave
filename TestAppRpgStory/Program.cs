using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using Models.RpgStoryStart;

namespace TestAppRpgStory
{
    class Program
    {
        private readonly StoryDummyContext _dummyContext;

        public Program()
        {
            _dummyContext = new StoryDummyContext();
        }

        static void Main(string[] args)
        {
            var stories = StaticStory();
            foreach (var story in stories)
            {
                Console.WriteLine(story.Title + "\n\r");
                foreach (var dialog in story.Dialogs)
                {
                    Console.WriteLine(dialog.DialogId + "\n\r");
                    foreach (var conversation in dialog.Conversations)
                    {
                        Console.WriteLine(conversation.Conversation + "\n\r");
                        foreach (var conversationOption in conversation.ConversationOptions)
                        {
                            Console.WriteLine(conversationOption + "\n\r");
                        }
                    }
                }
            }
            
            Console.ReadKey();
        }

        private static IEnumerable<Story> StaticStory()
        {
            var program = new Program();
            return program.StoryToTell();
        }

        public List<Story> StoryToTell()
        {
            return _dummyContext.Stories().ToList();
        }
    }
}
