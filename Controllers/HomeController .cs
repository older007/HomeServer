using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Unity3dLogs.Models;

namespace Unity3dLogs.Controllers
{
    [Route("api/")]
    public class HomeController : Controller
    {
        public List<UserTask> UsersTasks = new List<UserTask>();
        [HttpGet("Get")]
        public IEnumerable<UserTask> GetAll()
        {
            return UsersTasks;
        }

        [HttpPost("Post")]
        public IActionResult Create([FromBody] UserTask item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            UsersTasks.Add(item);

            return CreatedAtRoute("GetTodo", new { id = item.Header }, item);
        }

        public IActionResult Index()
        {
            return View(UsersTasks);
        }
    }
}
