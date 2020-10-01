using System;
using Microsoft.AspNetCore.Mvc;
using PROJECTName.Application.DTOs;
using PROJECTName.Application.Interfaces;

namespace PROJECTName.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleApplicationService exampleApplicationService;

        public ExampleController(IExampleApplicationService exampleApplicationService) => this.exampleApplicationService = exampleApplicationService;

        [HttpPost]
        public IActionResult Post([FromBody] ExampleDTO exampleDTO)
        {
            try
            {
                exampleApplicationService.Add(exampleDTO);

                return Ok("Example added successfully.");
            }
            catch (Exception ex)
            {

                return BadRequest(error: ex.Message);
            }
        }
    }
}
