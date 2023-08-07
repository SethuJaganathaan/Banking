using Application.DTO;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Persistence.Context;

namespace Application.UserKycDetail
{
    public class Create
    {
        public class Command : IRequest
        {
            public UserKycDTO userKycDTO { get; set; }
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
                request.userKycDTO.UserKycid = Guid.NewGuid();
                var userKycDetail = _mapper.Map<UserKycdetail>(request.userKycDTO);
                
                using (var memoryStream = new MemoryStream())
                {
                    await request.userKycDTO.file.CopyToAsync(memoryStream);
                    userKycDetail.Filedata = memoryStream.ToArray();
                    userKycDetail.Filename = request.userKycDTO.file.FileName;
                }

                _context.UserKycdetails.Add(userKycDetail);
                await _context.SaveChangesAsync();

                return Unit.Value;;
            }
        }
    }
}