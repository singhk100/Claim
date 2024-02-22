using Claim.Models;
namespace Claim.Interfaces
{
    public interface IClaimServices
    {
        public List<Claims> GetClaims(int claimId);
        public Claims CreateClaim(Claims claim);
        public List<Policy> GetPolicy(int policyId );

        public Policy CreatePolicy(Policy policy);
        public List<Customer> GetCustomer(int customerId);
        public Customer CreateCustomer(Customer customer);
        public List<Claimant> GetClaimant(int claimantId);
        public Claimant CreateClaimant(Claimant claimant);

    }
}
