﻿using System.Collections.Generic;
using Models.RpgStoryStart;

namespace DataLayer
{
    public class StoryDummyContext
    {
        /// <summary>
        /// Dummy data for mock up of RPG stoiry system
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StoryModel> Stories(int id)
        {
            //Id is currently not used

            var stories = new List<StoryModel>();
            const int toProduce = 1;

            for (var i = 0; i < toProduce; i++)
            {
                stories.Add(CreateStory(i + 1));
            }

            return stories;
        }

        /// <summary>
        /// Create a story
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private StoryModel CreateStory(int id)
        {
            var story = new StoryModel
            {
                StoryId = id,
                Title = $"Story title {id}",
            };


            const int conversationToDo = 3;

            for (var i = 0; i <= conversationToDo; i++)
            {
                if(i != conversationToDo)
                    story.Conversations.Add(CreateConversation(i));
                else
                {
                    story.Conversations[i - 1].StoryLeadId = i;
                }
            }

            return story;
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
            return $"{id} : Option";
        }
    }
}