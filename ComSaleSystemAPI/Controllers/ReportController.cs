using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComSaleSystemAPI.Repositories;
using ComSaleSystemAPI.Models;
using ComSaleSystemAPI.Context;

namespace ComSaleSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        ReportRepository ReportRepo;
        public ReportController()
        {
            var context = new SaleSystemContext();
            ReportRepo = new ReportRepository(context);
        }

        [HttpGet("InventoryReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetInventoryReport()
        {
            var value = ReportRepo.InventoryReport();
            return Ok(new { Message = "OK", Data = value });
        }
    }
}
