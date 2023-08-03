namespace Domain.Entities;

public partial class PersonalDetail
{
    public Guid UserId { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public long? Mobilenumber { get; set; }

    public string Pancard { get; set; }

    public string Aadharcard { get; set; }

    public DateTime? Dob { get; set; }

    public string Address { get; set; }

    public virtual ICollection<UserKycdetail> UserKycdetails { get; set; } = new List<UserKycdetail>();

    public virtual ICollection<UserSecurityQuestion> UserSecurityQuestions { get; set; } = new List<UserSecurityQuestion>();
}
