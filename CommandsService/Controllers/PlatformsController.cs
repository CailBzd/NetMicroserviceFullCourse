using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("Api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
        }

        [HttpPost]
        public ActionResult TestInboudConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test ok from Platforms Controller");
        }
    }
}
