using Application.DTO;
using Application.Persons;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PersonController : BaseApiController
    {
        private readonly IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson(PersonDTO personDTO)
        {
            return Ok(await Mediator.Send(new Create.Command {personalDetail = personDTO}));
        }
    }
}