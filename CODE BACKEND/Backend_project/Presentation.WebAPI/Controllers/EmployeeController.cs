using Application.Service.EmployeeFeature.Commands.CreateEmployee;
using Application.Service.EmployeeFeature.Commands.DeleteEmployee;
using Application.Service.EmployeeFeature.Commands.UpdateEmployee;
using Application.Service.EmployeeFeature.Queries.GetAllEmployee;
using Application.Service.EmployeeFeature.Queries.GetEmployeeById;
using Domain.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseAPIController
    {
        [HttpPost("Create")]
        public async Task<ActionResult> Create(CreateEmployeeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        [HttpGet("Get-All")]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllEmployeeQuery()));
        }

        [HttpPut("Update")]
        public async Task<ActionResult> Update(UpdateEmployeeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        [HttpPost("Get-All-Byid")]
        public async Task<ActionResult> GetAllById(GetEmployeeByIdQuery command)
        {
            return Ok(await Mediator.Send(command));
        }
        


        [HttpPut("Delete")]
        public async Task<ActionResult> Delete(DeleteEmployeeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }




    }
}
