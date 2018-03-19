using System.Collections.Generic;
using Models.RpgStoryStart;

namespace DataLayer
{
    public class StoryDummyContext
    {
        /// <summary>
        /// Dummy data for mock up of RPG system, would usually run off Server or maybe a file?
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Story> Stories()
        {
            var stories = new List<Story>();
            const int toProduce = 10;

            for (var i = 0; i < toProduce; i++)
            {
                stories.Add(CreateStory(i + 1));
            }

            return stories;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Story CreateStory(int id)
        {
            var story = new Story
            {
                Id = id,
                Title = $"Story title {id}"
            };
            const int dialogsToCreate = 5;

            for (var i = 0; i <= dialogsToCreate; i++)
            {
                story.Dialogs.Add(CreateDialog(i));
            }

            return story;
        }

        private Dialog CreateDialog(int id)
        {
            var dialog = new Dialog
            {
                DialogId = id,
            };
            const int conversationToDo = 3;

            for (var i = 0; i <= conversationToDo; i++)
            {
                dialog.Conversations.Add(CreateConversation(i));
            }

            return dialog;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ConversationModel CreateConversation(int id)
        {
            var conversation = new ConversationModel
            {
                ConversationId = id,
                Conversation = "Hey there buddy, how's it going?",
            };
            const int numOfOptions = 3;
            for (var i = 0; i < numOfOptions; i++)
            {
                conversation.ConversationOptions.Add(ConversationOption(i));
            }

            return conversation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private string ConversationOption(int id)
        {
            return $"Option {id}";
        }
    }
}