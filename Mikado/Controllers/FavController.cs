using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mikado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavController : ControllerBase
    {
        // GET: api/Fav
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Film1", "Film2" };
        }

        // GET: api/Fav/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Fav
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Fav/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
