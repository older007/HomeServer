using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Unity3dLogs.Models;

namespace Unity3dLogs.Controllers
{
    [Route("api/")]
    public class HomeController : Controller
    {
        public static List<HoloLog> Holologs = new List<HoloLog>();

        [HttpGet("Get")]
        public IEnumerable<HoloLog> GetAll()
        {
            return Holologs;
        }

        [HttpPost("Post")]
        public IActionResult Create([FromBody] HoloLog item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            Holologs.Add(item);

            return CreatedAtRoute("GetTodo", new { id = item.LogMessage }, item);
        }

        public IActionResult Index()
        {
            return View(Holologs);
        }
    }
}
