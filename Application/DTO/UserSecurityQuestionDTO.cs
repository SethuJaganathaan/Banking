namespace Application.DTO
{
    public class UserSecurityQuestionDTO
    {
        public Guid UserQuestionId { get; set; }

        public Guid UserId { get; set; }

        public List<QuestionAnswerDTO> Questions { get; set; }
    }
}