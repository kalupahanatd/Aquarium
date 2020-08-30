using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aquarium.Models;
using Aquarium.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aquarium.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {

        private IFishService _fishService;

        public FishController(IFishService fishService)
        {
            _fishService = fishService;
        }





        // GET: api/<FishController>
        [HttpGet]
        public IEnumerable<Fish> Get() => _fishService.GetAll();

        // GET api/<FishController>/5
        [HttpGet("{id}")]
        public Fish Get(int id)
        {
            return _fishService.Get(id);
        }

        // POST api/<FishController>
        [HttpPost]
        public void Post([FromBody] Fish newfish)
        {
            _fishService.Add(newfish);
        }

        // PUT api/<FishController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Fish fish)
        {
            _fishService.Update(id, fish);
        }

        // DELETE api/<FishController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _fishService.Delete(id);
        }
    }
}
