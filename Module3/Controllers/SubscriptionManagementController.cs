using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionManagementController : ControllerBase
    {
        // GET: api/<SubscriptionManagementController>
        [HttpGet]
        //[HttpGet("[controller]/[action]")]
        public IEnumerable<string> ListAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SubscriptionManagementController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SubscriptionManagementController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SubscriptionManagementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubscriptionManagementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
