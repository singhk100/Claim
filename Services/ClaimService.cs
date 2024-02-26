using Claim.ClaimDBContext;
using Claim.Interfaces;
using Claim.Models;
using Claim.Repository;
using Claim.ViewModel;
using Newtonsoft;
using Newtonsoft.Json.Linq;
namespace Claim.Services
{
    public class ClaimService : IClaimServices
    {
        readonly ClaimsDBContext _dbContext;
        readonly IClaimsRepository _claimsRepository;
        readonly IPolicyRepository _policyRepository;
        readonly ICustomerRepository _customerRepository;
        readonly IClaimantRepository _claimantRepository;
        readonly IGenericRepository _genericRepository;

        public ClaimService(ClaimsDBContext dbContext, ClaimsRepository claimsRepository, PolicyRepository policyRepository, CustomerRepository customerRepository, ClaimantRepository claimantRepository, GenericRepository genericRepository)
        {
            _dbContext = dbContext;
            _claimsRepository = claimsRepository;
            _policyRepository = policyRepository;
            _customerRepository = customerRepository;
            _claimantRepository = claimantRepository;
            _genericRepository = genericRepository;
        }

        public List<Claims> GetClaims(int claimId = 0)
        {
            var ClaimList = _claimsRepository.GetClaimDetails(claimId);
            return ClaimList;
        }
        public Claims CreateClaim(Claims claim)
        {
            var claims = _claimsRepository.CreateClaim(claim);
            return claims;

        }
        public List<Policy> GetPolicy(int policyId = 0)
        {
            var PolicyList  = _policyRepository.GetPolicyDetails(policyId);
            return PolicyList;
        }
        public Policy CreatePolicy(Policy policy)
        {
            var policys = _policyRepository.CreatePolicy(policy);
            return policys;

        }
        public List<Customer> GetCustomer(int customerId = 0)
        {
            var customerList = _customerRepository.GetCustomerDetails(customerId);
            return customerList;
        }
        public Customer CreateCustomer(Customer customer)
        {
            var customers = _customerRepository.CreateCustomer(customer);
            return customers;

        }
        public List<Claimant> GetClaimant(int claimantId = 0)
        {
            var claimantList = _claimantRepository.GetClaimantDetails(claimantId);
            return claimantList;
        }
        public Claimant CreateClaimant(Claimant claimant)
        {
            var claimants = _claimantRepository.CreateClaimant(claimant);
            return claimants;

        }
        public Claimant GetMatchedData(Claimant claimant)
        {
            var claimants = _claimantRepository.CreateClaimant(claimant);
            return claimants;

        }
        public List<GenericVM> ReceivedValue(List<GenericVM> json)
        {

            var generic =  _genericRepository.GetGeneric(json);

            return generic;
        }
    }
}
