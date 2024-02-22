using Claim.Models;

namespace Claim.Interfaces
{
    public interface IQuery
    {
        public string GetClaims();
        public string GetClaimsById(int claimid);

        public string CreateClaim(Claims claims);
        public string GetPolicy();
        public string GetPolicyById(int policyid);

        public string CreatePolicy(Policy policy);
        public string GetCustomer();
        public string GetCustomerById(int policyid);

        public string CreateCustomer(Customer customer);
        public string GetClaimant();
        public string GetClaimantById(int policyid);

        public string CreateClaimant(Customer customer);


    }
}
