using Application.DTO;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Persistence.Context;

namespace Application.Persons
{
    public class Details
    {
        public class Query : IRequest<PersonDTO>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, PersonDTO>
        {
            private readonly BankingContext _context;
            private readonly IMapper _mapper;
            public Handler(BankingContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<PersonDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var personDto = _mapper.Map<PersonDTO>(await _context.PersonalDetails.FindAsync(request.Id));
                return personDto;
            }
        }
    }
}