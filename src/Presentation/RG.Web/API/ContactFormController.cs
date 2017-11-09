using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RG.Core.Models;

namespace RG.Web.API
{
    [Produces("application/json")]
    [Route("api/ContactForm")]
    public class ContactFormController : Controller
    {

        // GET api/ContactForm
        [HttpGet]
        public IActionResult Get()
        {
            
            ContactForm nextQuestion = new ContactForm() { Name = "test", Email = "test2" };

            if (nextQuestion == null)
            {
                return this.NotFound();
            }

            return Ok(nextQuestion);
        }

        // POST: api/ContactForm
        [HttpPost]
        public IActionResult Post([FromBody] string searchTerm)
        {
            if (searchTerm == null)
            {
                return BadRequest();
            }

            return Json (searchTerm );
        }


        // POST: api/ContactForm/SearhUser
       
    }
}