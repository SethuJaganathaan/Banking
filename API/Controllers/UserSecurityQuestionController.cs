using Application.DTO;
using Application.UserSecurityQuestions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserSecurityQuestionController : BaseApiController
    {
        private readonly IMediator _mediator;
        public UserSecurityQuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSQD(UserSecurityQuestionDTO userSecurityQuestionDTO)
        {
            return Ok(await Mediator.Send(new Create.Command {userSecurityQuestionDTO = userSecurityQuestionDTO}));
        }
    }
}