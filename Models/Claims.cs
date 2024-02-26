namespace Claim.Models
{
    public class Claims
    {
        public int ID { get; set; }
        public int CustomerId { get; set;}
        public int PolicyId { get; set;}
        public string? MobileNunber { get; set;}
        public string? ClaimDetails { get; set;}
        public int SumAssured { get; set;}
        public bool IsSubmitted { get; set;}
        public bool IsSelfProcess { get; set; }
        public bool IsRejected { get; set; }
        public String? ReasonForReject { get; set; }



    }
}
