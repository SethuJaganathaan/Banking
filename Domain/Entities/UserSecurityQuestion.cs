namespace Domain.Entities;

public partial class UserSecurityQuestion
{
    public Guid UserQuestionId { get; set; }

    public Guid UserId { get; set; }

    public Guid QuestionId { get; set; }

    public string Answer { get; set; }

    public virtual SecurityQuestion Question { get; set; }

    public virtual PersonalDetail User { get; set; }
}
