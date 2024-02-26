using Claim.Interfaces;
using Claim.Models;
using System.Reflection.Metadata.Ecma335;

namespace Claim
{
    public class Query : IQuery
    {
        public string GetClaims()
        {
            string result = "Select * from Claims";
            return result;
        }
        public string GetClaimsById(int claimid)
        {
            string result = $"Select * from Claims where Id={claimid}";
            return result;
        }
        public string CreateClaim(Claims claims)
        {
            string result = $@"Insert into Claims values({claims.CustomerId},{claims.PolicyId},{claims.MobileNunber},
                                {claims.ClaimDetails},{claims.SumAssured},{claims.IsSubmitted},{claims.IsSelfProcess})";
            return result;

        }
        public string GetPolicy()
        {
            string result = "Select * from Policy";
            return result;
        }
        public string GetPolicyById(int policyid)
        {
            string result = $"Select * from Policy where Id={policyid}";
            return result;
        }
        public string CreatePolicy(Policy policy)
        {
            string result = $@"Insert into Policy (PolicyName,PolicyInceptionDate,PolicyOutceptionDate,PolicyAmount) values('{policy.PolicyName}','{policy.PolicyInceptionDate}','{policy.PolicyOutceptionDate}',
                                '{policy.PolicyAmount}')";//,{policy.PolicyImage})";
            return result;

        }
        public string GetCustomer()
        {
            string result = "Select * from Customer";
            return result;
        }
        public string GetCustomerById(int customerId)
        {
            string result = $"Select * from Customer where Id={customerId}";
            return result;
        }
        public string CreateCustomer(Customer customer)
        {
            string result = $@"Insert into Customer (PolicyId,CustomerDetails,PolicyHolderName,MobileNumber) values('{customer.PolicyId}','{customer.CustomerDetails}','{customer.PolicyHolderName},'{customer.MobileNumber}')";
            return result;

        }
        public string GetClaimant()
        {
            string result = "Select * from Claimant";
            return result;
        }
        public string GetClaimantById(int claimantId)
        {
            string result = $"Select * from Claimant where Id={claimantId}";
            return result;
        }
        public string CreateClaimant(Customer customer)
        {
            string result = $@"Insert into Customer (PolicyId,CustomerDetails,PolicyHolderName,MobileNumber) values('{customer.PolicyId}','{customer.CustomerDetails}','{customer.PolicyHolderName},'{customer.MobileNumber}')";
            return result;

        }
        //public string MatchedCustomer()
        //{

        //    //string result = $@"select cu.id,cu.MobileNumber,cu.PolicyId,cu.CustomerDetails,p.PolicyAmount from Customer cu join policy p
        //    //                on cu.PolicyID=p.ID";
        //    return result;
        //}
    }
}
