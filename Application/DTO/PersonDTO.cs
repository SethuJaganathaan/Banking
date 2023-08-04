namespace Application.DTO
{
    public class PersonDTO
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long Mobilenumber { get; set; }

        public string Pancard { get; set; }

        public string Aadharcard { get; set; }

        public DateTime? Dob { get; set; }

        public string Address { get; set; }
    }
}