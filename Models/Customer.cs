namespace Claim.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public string? CustomerDetails { get; set;}
        public string? PolicyHolderName { get; set; }
        public string? MobileNumber { get; set;}
        public string? policyName { get; set; }
        public int SumAssured { get; set;}

    }
}
