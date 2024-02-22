using Claim.ClaimDBContext;
using Claim.Interfaces;
using Claim.Models;
using Microsoft.EntityFrameworkCore;

namespace Claim.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        readonly ClaimsDBContext _dbContext = new();
        readonly IQuery _query;
        //public ClaimsRepository()
        //{

        //}
        public PolicyRepository(ClaimsDBContext dbContext, Query query)
        {
            _dbContext = dbContext;
            _query = query;
        }

        public List<Policy> GetPolicyDetails(int policyid = 0)
        {
            List<Policy> PolicyList = new List<Policy>();
            try
            {
                if (policyid == 0)
                {
                    PolicyList = _dbContext.policy.FromSqlRaw(_query.GetPolicy()).ToList();
                }
                else
                {
                    PolicyList = _dbContext.policy.FromSqlRaw(_query.GetPolicyById(policyid)).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return PolicyList;
        }
        public Policy CreatePolicy(Policy policy)
        {
            if (policy != null)
            {
                try
                {
                    _dbContext.policy.Add(policy);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }
            return policy;
        }
    }
}

