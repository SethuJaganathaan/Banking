using Application.DTO;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Persistence.Context;

namespace Application.UserSecurityQuestions
{
    public class Create
    {
        public class Command : IRequest
        {
            public UserSecurityQuestionDTO userSecurityQuestionDTO { get; set; }
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
                
                // var result = _mapper.Map<UserSecurityQuestion>(request.securityQuestionDTO);
                // _context.UserSecurityQuestions.Add(result);

                // await _context.SaveChangesAsync();

                // var userQuestionId = Guid.NewGuid(); 

                var userSecurityQuestions = _mapper.Map<List<UserSecurityQuestion>>(request.userSecurityQuestionDTO.Questions);

                foreach (var userSecurityQuestion in userSecurityQuestions)
                {
                    var id = Guid.NewGuid();
                    userSecurityQuestion.UserQuestionId = id;
                    userSecurityQuestion.UserId = request.userSecurityQuestionDTO.UserId;
                    _context.UserSecurityQuestions.Add(userSecurityQuestion);
                }

                await _context.SaveChangesAsync();


                return Unit.Value;
            }
        }
    }
}