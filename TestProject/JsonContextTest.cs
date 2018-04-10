using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using Xunit;
using System.IO;
using BusinessLogic.StoryService;

namespace TestProject
{
    public class JsonContextTest
    {
        IRespository _respository;
        IStoryService _storyService;
        const string storyFilePath = @"E:\Development\GoogleApiTest\TestAppRpgStory\Story.json";
        public JsonContextTest()
        {
            _respository = new Repository();
            _storyService = new StoryService();
        }

       [Fact]
        void TestStoryJsonGet()
        {
            var actual = _respository.JsonDataContext.GetJsonFromFile(storyFilePath);
            //Excpeted
            var expected = File.ReadAllText(storyFilePath);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void TestStoryGetBusiness()
        {
            var modelOfStory = _storyService.Get(storyFilePath);
            Assert.NotNull(modelOfStory);
        }
    }
}
