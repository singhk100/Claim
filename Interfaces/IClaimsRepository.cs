using Claim.Models;

namespace Claim.Interfaces
{
    public interface IClaimsRepository 
    {
        public List<Claims> GetClaimDetails(int claimid);
        public Claims CreateClaim(Claims claim);


    }
}
