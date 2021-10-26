using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComSaleSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        ProductTypeRepository proRepo;

        public ProductTypeController()
        {
            var context = new SaleSystemContext();
            proRepo = new ProductTypeRepository(context);
        }

        // GET: api/<ProductTypeController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };
            return Ok(new { Message = "OK", Data = proRepo.GetProductTypes() });
        }

        // GET api/<ProductTypeController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByID(int id)
        {
            var value = proRepo.GetProductTypeById(id);
            return Ok(new { Message = "OK", Data = value });
        }

        // POST api/<ProductTypeController>
        [HttpPost("Insert")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] ProductType value)
        {
            try
            {
                proRepo.InsertProductType(value);
                proRepo.Save();
                return StatusCode(StatusCodes.Status201Created, new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // PUT api/<ProductTypeController>/5
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put([FromBody] ProductType value)
        {
            try
            {
                proRepo.UpdateProductType(value);
                proRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // DELETE api/<ProductTypeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                proRepo.DeleteProductType(id);
                proRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
    }
}
