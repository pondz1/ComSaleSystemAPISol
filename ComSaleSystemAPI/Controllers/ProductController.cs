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
    public class ProductController : ControllerBase
    {
        ProductRepository proRepo;

        public ProductController()
        {
            var context = new SaleSystemContext();
            proRepo = new ProductRepository(context);
        }

        // GET: api/<ProductController>/All/1
        [HttpGet("Get/{path}/{key}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(string key, string path)
        {
            //return new string[] { "value1", "value2" };
             return Ok(new { Message = "OK", Data = proRepo.GetProducts(key, path)});
        }

        // GET: api/<ProductController>/Search/key
        [HttpPost("Search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(ProductSearch key)
        {
            //return new string[] { "value1", "value2" };
            return Ok(new { Message = "OK", Data = proRepo.GetProductSearch(key) ,Key = key});
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByID(int id)
        {
            var value = proRepo.GetProductById(id);
            return Ok(new { Message = "OK", Data = value });
        }

        // POST api/<ProductController>
        [HttpPost("Insert")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] Product value)
        {
            try
            {
                proRepo.InsertProduct(value);
                proRepo.Save();
                return StatusCode(StatusCodes.Status201Created, new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put([FromBody] Product value)
        {
            try
            {
                proRepo.UpdateProduct(value);
                proRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                proRepo.DeleteProduct(id);
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
