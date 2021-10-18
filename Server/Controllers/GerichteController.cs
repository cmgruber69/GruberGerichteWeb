using GruberGerichteWeb.Server.Interface;
using GruberGerichteWeb.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GruberGerichteWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerichteController : ControllerBase
    {
        private readonly IGerichte objgerichte;

        public GerichteController(IGerichte _objgerichte)
        {
            objgerichte = _objgerichte;
        }

        // GET: api/<GerichteController>
        [HttpGet]
        public IEnumerable<Gerichte> Get()
        {
            return objgerichte.GetAllGerichte();
        }

        // GET api/<GerichteController>/5
        [HttpGet("{id}")]
        public Gerichte Get(string id)
        {
            return objgerichte.GetGerichteData(id);
        }

        // POST api/<GerichteController>
        [HttpPost]
        public void Post([FromBody] Gerichte gerichte)
        {
            objgerichte.AddGerichte(gerichte);
        }

        // PUT api/<GerichteController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Gerichte gerichte)
        {
            objgerichte.UpdateGerichte(gerichte);
        }

        // DELETE api/<GerichteController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            objgerichte.DeleteGerichte(id);
        }
    }
}
