using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using Utilities;
using Models.RpgStoryStart;

namespace TestProject
{
    public class StorySchemaValidationUnitTest
    {
        JSchema GetSchema(string filePath = @"E:\Development\GoogleApiTest\TestAppRpgStory\StorySchema.json")
        {
            JSchema schema;
            using (StreamReader file = File.OpenText(filePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                schema = JSchema.Load(reader);
            }
            return schema;
        }

        JObject GetObject(string filePath = @"E:\Development\GoogleApiTest\TestAppRpgStory\Story.json")
        {
            JObject json;
            using (StreamReader file = File.OpenText(filePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                json = JObject.Load(reader);
            }
            return json;
        }

        [Fact]
        public void CheckShemaWorks()
        {
            JSchema schema = GetSchema();
            JObject story = GetObject();
            var valid = story.IsValid(schema, out IList<string> messages);
            var noErrors = !messages.Any();
            Assert.True(noErrors);
        }

        [Fact]
        public void JsonModelHelperTest()
        {
            //Arrange
            var json = File.ReadAllText(@"E:\Development\GoogleApiTest\TestAppRpgStory\Story.json");
            //Act
            var model = JsonModelHelper.JsonToModel<StoryModel>(json);
            //Assert
            Assert.NotNull(model);
        }
    }
}

