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
    public class ProGroupController : ControllerBase
    {
        readonly ProductGroupRepository PGRepo;
        public ProGroupController()
        {
            var context = new SaleSystemContext();
            PGRepo = new ProductGroupRepository(context);
        }

        //GET: api/<ProGroupController>
        [HttpGet]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };
            var value = PGRepo.GetProductGroups();
            return Ok(new { Message = "OK", Data = value });
        }

        [HttpGet("Approve")]
        public IActionResult GetApprove()
        {
            //return new string[] { "value1", "value2" };
            var value = PGRepo.GetProductGroupsApprove();
            return Ok(new { Message = "OK", Data = value });
        }

        // GET api/<ProGroupController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = PGRepo.GetProductGroupById(id);
            return Ok(new { Message = "OK", Data = value });
        }

        // POST api/<ProGroupController>
        [HttpPost("Insert")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] ProductGroup value)
        {
            try
            {
                //proRepo.InsertProduct(value);
                //proRepo.Save();
                PGRepo.InsertProductGroup(value);
                PGRepo.Save();
                return StatusCode(StatusCodes.Status201Created, new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }

        // PUT api/<ProGroupController>/5
        [HttpPut("Update")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put([FromBody] ProductGroup value)
        {
            try
            {
                PGRepo.UpdateProductGroup(value);
                PGRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }


        [HttpPut("Update/Status")]
        public IActionResult PutStatus([FromBody] ProductGroup value)
        {
            try
            {
                PGRepo.UpdateStatusGroup(value);
                PGRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
        

        // DELETE api/<ProGroupController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
                try
            {
                PGRepo.DeleteProductGroup(id);
                PGRepo.Save();
                return Ok(new { Message = "Success" });
            }
            catch (Exception e)
            {
                return BadRequest(new { e.Message });
            }
        }
    }
}
