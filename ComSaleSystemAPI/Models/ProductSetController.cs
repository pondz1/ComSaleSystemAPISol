using ComSaleSystemAPI.Context;
using ComSaleSystemAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComSaleSystemAPI.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSetController : ControllerBase
    {
        ProductSetRepository ProSetRepo;
        public ProductSetController()
        {
            var context = new SaleSystemContext();
            ProSetRepo = new(context);
        }

        // GET: api/<ProductSetController>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByProGroup(int id)
        {

            var value = ProSetRepo.GetByProGroup(id);
            return Ok(new { Message = "OK", Data = value });
        }

        // GET: api/<ProductSetController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ProductSetController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProductSetController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProductSetController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductSetController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        [HttpDelete("List")]
        public IActionResult Delete(ProSetList json)
        {
            try
            {
                ProSetRepo.DeleteProductSetList(json.ProSetID);
                ProSetRepo.Save();
                //proRepo.DeleteProduct(id);
                //proRepo.Save();
                return Ok(new { Message = "Success", Test = json });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
    }
}
