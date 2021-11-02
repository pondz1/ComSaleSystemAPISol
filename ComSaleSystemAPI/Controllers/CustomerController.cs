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
    public class CustomerController : ControllerBase
    {
        CustomerRepository cusRepo;
        public CustomerController()
        {
            var context = new SaleSystemContext();
            cusRepo = new CustomerRepository(context);
        }

        // GET: api/<CustomerController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };
            return Ok(new { Message = "OK", Data = cusRepo.GetCustomers() });
        }

        // GET: api/<CustomerController>
        [HttpGet("Search/{key}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Search(string key)
        {
            //return new string[] { "value1", "value2" };
            return Ok(new { Message = "OK", Data = cusRepo.SearchCustomers(key) });
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByID(int id)
        {
            var value = cusRepo.GetCustomerById(id);
            return Ok(new { Message = "OK", Data = value });
        }

        // POST api/<CustomerController>
        [HttpPost("Insert")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] Customer value)
        {
            try
            {
                cusRepo.InsertCustomer(value);
                cusRepo.Save();
                return StatusCode(StatusCodes.Status201Created, new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // PUT api/<CustomerController>/5
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put([FromBody] Customer value)
        {
            try
            {
                cusRepo.UpdateCustomer(value);
                cusRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                cusRepo.DeleteCustomer(id);
                cusRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
    }
}
