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
    public class ProductBuyController : ControllerBase
    {
        ProductBuyRepository proBuyRepo;

        public ProductBuyController()
        {
            var context = new SaleSystemContext();
            proBuyRepo = new ProductBuyRepository(context);
        }

        // GET: api/<ProductBuyController>/All/1
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };
             return Ok(new { Message = "OK", Data = proBuyRepo.GetProductBuys()});
        }

        // GET: api/<ProductBuyController>/Search/key
        //[HttpPost("Search")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public IActionResult Get(ProductBuySearch key)
        //{
        //    //return new string[] { "value1", "value2" };
        //    return Ok(new { Message = "OK", Data = proBuyRepo.GetProductBuySearch(key) ,Key = key});
        //}

        // GET api/<ProductBuyController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByID(int id)
        {
            var value = proBuyRepo.GetProductBuyById(id);
            return Ok(new { Message = "OK", Data = value });
        }

        // POST api/<ProductBuyController>
        [HttpPost("Insert")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] ProductBuy value)
        {
            try
            {
                proBuyRepo.InsertProductBuy(value);
                proBuyRepo.Save();
                return StatusCode(StatusCodes.Status201Created, new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // PUT api/<ProductBuyController>/5
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put([FromBody] ProductBuy value)
        {
            try
            {
                proBuyRepo.UpdateProductBuy(value);
                proBuyRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // DELETE api/<ProductBuyController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                proBuyRepo.DeleteProductBuy(id);
                proBuyRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
    }
}
