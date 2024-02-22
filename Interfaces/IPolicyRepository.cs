using Claim.Models;

namespace Claim.Interfaces
{
    public interface IPolicyRepository
    {
        public List<Policy> GetPolicyDetails(int policyid = 0);
        public Policy CreatePolicy(Policy policy);


    }
}
