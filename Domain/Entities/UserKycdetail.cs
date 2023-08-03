namespace Domain.Entities;

public partial class UserKycdetail
{
    public Guid UserKycid { get; set; }

    public Guid? UserId { get; set; }

    public Guid? KycId { get; set; }

    public byte[] Filedata { get; set; }

    public string Filename { get; set; }

    public virtual Kyc Kyc { get; set; }

    public virtual PersonalDetail User { get; set; }
}
