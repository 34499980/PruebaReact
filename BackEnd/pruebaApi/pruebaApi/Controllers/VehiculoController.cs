using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pruebaApi.Model;
using Repository.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pruebaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoRep _vehiculoRep;
        public VehiculoController(IVehiculoRep vehiculoRep)
        {
            this._vehiculoRep = vehiculoRep;
        }
        // GET: api/<VehiculoController>
        [HttpGet]        
        public IEnumerable<Vehiculo> Get()
        {
            return _vehiculoRep.GetAllVehiculos();
        }

        // GET api/<VehiculoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehiculoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehiculoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehiculoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
