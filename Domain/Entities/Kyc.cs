using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Kyc
{
    public Guid KycId { get; set; }

    public string ProofType { get; set; }

    public virtual ICollection<UserKycdetail> UserKycdetails { get; set; } = new List<UserKycdetail>();
}
