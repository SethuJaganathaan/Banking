using Application.DTO;
using Application.UserKycDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    public class UserKycDetailController : BaseApiController
    {
        private readonly IMediator _mediator;
        public UserKycDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserKycDetail([FromQuery]UserKycDTO _userKycDTO)
        {
            return Ok(await Mediator.Send(new Create.Command {userKycDTO = _userKycDTO}));
        }
    }
}