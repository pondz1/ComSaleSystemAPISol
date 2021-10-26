using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComSaleSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository empRepo;

        public EmployeeController()
        {
            SaleSystemContext context = new SaleSystemContext();
            empRepo = new EmployeeRepository(context);
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            //IEnumerable < Employee >
            return Ok(new { Message = "OK", Data = empRepo.GetEmployees() });
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByID(int id)
        {

            var value = empRepo.GetEmployeeById(id);
            return Ok(new { Message = "OK", Data = value });
        }

        // POST api/<EmployeeController>
        //[Route("~/[controller]/update")]
        [HttpPost("Insert")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] Employee value)
        {
            
            try
            {
                empRepo.InsertEmployee(value);
                empRepo.Save();
                return StatusCode(StatusCodes.Status201Created, new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put(Employee value)
        {
            
            try
            {
                empRepo.UpdateEmployee(value);
                empRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            
            try
            {
                empRepo.DeleteEmployee(id);
                empRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
    }
}
