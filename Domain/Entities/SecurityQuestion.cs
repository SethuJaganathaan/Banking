namespace Domain.Entities;

public partial class SecurityQuestion
{
    public Guid QuestionId { get; set; }

    public string Question { get; set; }

    public virtual ICollection<UserSecurityQuestion> UserSecurityQuestions { get; set; } = new List<UserSecurityQuestion>();
}
