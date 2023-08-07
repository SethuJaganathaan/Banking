using Microsoft.AspNetCore.Http;

namespace Application.DTO
{
    public class UserKycDTO
    {
        public Guid UserKycid { get; set; }
        public Guid UserId { get; set; }
        public Guid KycId { get; set; }
        public IFormFile file { get; set; }
    }

}