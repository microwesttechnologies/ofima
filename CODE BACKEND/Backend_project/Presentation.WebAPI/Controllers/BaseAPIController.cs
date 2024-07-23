using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseAPIController : ControllerBase
    {
        private IMediator mediator;

        protected IMediator Mediator => 
            mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
    }
}
