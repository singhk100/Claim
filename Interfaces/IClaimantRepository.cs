using Claim.Models;

namespace Claim.Interfaces
{
    public interface IClaimantRepository
    {
        public List<Claimant> GetClaimantDetails(int claimantId);
        public Claimant CreateClaimant(Claimant claimant);

    }
}
