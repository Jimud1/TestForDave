using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.IO;
using Xunit;

namespace TestProject
{
    public class StorySchemaValidationUnitTest
    {
        [Fact]
        public void CheckShemaWorks()
        {
            JSchema schema;
            using (StreamReader file = File.OpenText(@"E:\Development\GoogleApiTest\TestAppRpgStory\StorySchema.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
               schema = JSchema.Load(reader);
                // validate JSON
                Assert.NotNull(schema);
            }
        }
        [Fact]
        public void CheckStoryAgainstSchema()
        {
            JObject story = JObject.Parse(@"
            {
	            'story_id' : 1,
	            'title': 'Test Story',
	            'conversations':[{
		            'conversation_id': 1,
		            'conversation': 'Hello there this is a test',
		            'conversation_options' ['One', 'Two', 'Thee']
	            }]
            }");

        }
    }
}
