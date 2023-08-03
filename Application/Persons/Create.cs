using Application.DTO;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Persistence.Context;

namespace Application.Persons
{
    public class Create
    {
        public class Command : IRequest
        {
            public PersonDTO personalDetail { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly BankingContext _context;
            private readonly IMapper _mapper;
            public Handler(BankingContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                request.personalDetail.UserId = Guid.NewGuid();
                var person =  _mapper.Map<PersonalDetail>(request.personalDetail);
                _context.PersonalDetails.Add(person);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}