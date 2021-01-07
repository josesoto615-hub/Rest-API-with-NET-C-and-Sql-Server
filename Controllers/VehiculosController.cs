using apivehiculos.Context;
using apivehiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apivehiculos.Controllers
{
    [Route("api/[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public VehiculosController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.vehiculos.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}", Name = "GetVehiculo")]
        public ActionResult Get(int id)
        {
            try
            {
                var vehi = _context.vehiculos.FirstOrDefault(g => g.id == id);
                return Ok(vehi);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody]Vehiculos_Bd vehiculo)
        {
            try
            {
                _context.vehiculos.Add(vehiculo);
                _context.SaveChanges();
                return CreatedAtRoute("GetVehiculo", new { id = vehiculo.id }, vehiculo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Vehiculos_Bd vehiculo)
        {
            try
            {
                if (vehiculo.id == id)
                {
                    _context.Entry(vehiculo).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetVehiculo", new { id = vehiculo.id }, vehiculo);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var vehi = _context.vehiculos.FirstOrDefault(v => v.id == id);
                if (vehi != null)
                {
                    _context.vehiculos.Remove(vehi);
                    _context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
