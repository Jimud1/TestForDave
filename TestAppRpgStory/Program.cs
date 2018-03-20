using System;
using System.Linq;
using System.Xml;
using Models.RpgStoryStart;

namespace TestAppRpgStory
{
    internal class Program
    {
        private static readonly StoryController StoryController;
        private static Story _currentStory;
        private const string NewLine = "\n\r";

        static Program()
        {
            StoryController = new StoryController();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            GetStory(1);
        }

        private static void GetStory(int id)
        {
            _currentStory = StoryController.GetStory(id);
            DisplayStory(_currentStory);
        }

        private static ConversationModel GetConversation(int id)
        {
            return _currentStory.Conversations.FirstOrDefault(x => x.ConversationId == id);
        }

        private static void DisplayConversation(ConversationModel conversation, bool? nextStory)
        {
            if (nextStory != null && (bool) nextStory)
            {
                if (conversation.StoryLeadId != null)
                {
                    GetStory((int)conversation.StoryLeadId);
                }    
            }

            WriteToConsole(conversation.Conversation);

            foreach (var conversationOption in conversation.ConversationOptions)
            {
                WriteToConsole(conversationOption);
            }

            int.TryParse(Console.ReadLine(), out var nextConversation);
            var leadingConversation = GetConversation(nextConversation);
            DisplayConversation(leadingConversation, conversation?.LeadingToStory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="story"></param>
        private static void DisplayStory(Story story)
        {
            //Id is currently not in use as dummy context but you get the jist
            //This function should change depending on your view
            WriteToConsole(story.Title);
            var conversation = story.Conversations.FirstOrDefault();
            DisplayConversation(conversation, conversation?.LeadingToStory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        private static void WriteToConsole(string text)
        {
            Console.WriteLine(text + NewLine);
        }
    }
}
