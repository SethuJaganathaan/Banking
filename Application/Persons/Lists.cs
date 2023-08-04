using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Application.Persons
{
    public class Lists
    {
        public class Query : IRequest<List<PersonalDetail>>
        {
            public PersonalDetail personalDetail { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<PersonalDetail>>
        {
            private readonly BankingContext _context;
            public Handler(BankingContext context)
            {
                _context = context;
            }
            public async Task<List<PersonalDetail>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.PersonalDetails.ToListAsync();
            }
        }
    }
}