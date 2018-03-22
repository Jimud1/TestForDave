using System.Collections.Generic;
using BusinessLogic.StoryService;
using Microsoft.AspNetCore.Mvc;
using Models.RpgStoryStart;

namespace GoogleApiTest.Controllers
{
    [Produces("application/json")]
    [Route("api/Story")]
    public class StoryController : Controller
    {
        private readonly IStoryService _storyService;
        private StoryModel _currentStory;
        public StoryController()
        {
            _storyService = new StoryService();
        }
        // GET: api/Story
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Story/5
        [HttpGet("{id}", Name = "Get")]
        public StoryModel Get(int id)
        {
            _currentStory = _storyService.Get(id);
            return _currentStory;
        }

        [HttpGet("Conversation/{id}", Name = "Get")]
        public ConversationModel GetConversation(int id)
        {
            return _currentStory.Conversations[id];
        }

        // POST: api/Story
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Story/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
