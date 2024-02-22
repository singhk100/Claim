namespace Claim.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string? PolicyName { get; set; }
        public string? PolicyInceptionDate { get; set;}
        public string? PolicyOutceptionDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int PolicyAmount { get; set; }
        
        //public string? PolicyImage {  get; set; }
    }
}
