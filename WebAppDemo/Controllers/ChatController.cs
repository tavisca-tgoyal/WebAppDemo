using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppDemo.Controllers
{
    [Route("chat")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "enter your message" };
        }

        [HttpGet("{msg}")]
        public string Get(string msg)
        {
            string output;
            if (msg == "hi")
            {
                output = "hello";
            }
            else if (msg == "hello")
                output = "hi";
            else
                return "I don't know what are you talking about";

            return output;
        }
    }
}