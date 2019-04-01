using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenHouseApp.Data;
using GreenHouseApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace GreenHouseApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private GreenHouseContext _context; 

        public ValuesController(GreenHouseContext Context)
        {
            _context = Context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // Used for testing
            //InsertColor();
            return new string[] { "value1", "value2", "value3", "value4" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            // Used for testing
            InsertColor();
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        /// <summary>
        /// Used for testing -- No real purpose
        /// </summary>
        private void InsertColor()
        {
            var color = new Color(
                name: "Bleu",
                description: "La couleur bleue crée l'illusion d'espace, elle symbolise la pureté, la fidélité mais aussi l'inaccessibilité"
                );
            _context.Colors.Add(color);
            _context.SaveChanges();
        }
    }
}
