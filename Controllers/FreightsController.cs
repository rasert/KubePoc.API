using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KubePoc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreightsController : ControllerBase
    {
        // GET: api/Freights
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Frete1", "Frete2" };
        }

        // GET: api/Freights/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Frete";
        }

        // POST: api/Freights
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Freights/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Freights/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
