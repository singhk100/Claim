using Claim.ClaimDBContext;
using Claim.Interfaces;
using Claim.Models;
using Microsoft.EntityFrameworkCore;

namespace Claim.Repository
{
    public class ClaimantRepository : IClaimantRepository
    {
        readonly ClaimsDBContext _dbContext = new();
        readonly IQuery _query;

        public ClaimantRepository(ClaimsDBContext dbContext, Query query)
        {
            _dbContext = dbContext;
            _query = query;
        }

        public List<Claimant> GetClaimantDetails(int Claimantid = 0)
        {
            List<Claimant> ClaimantList = new List<Claimant>();
            try
            {
                if (Claimantid == 0)
                {
                    ClaimantList = _dbContext.claimant.FromSqlRaw(_query.GetClaimant()).ToList();
                }
                else
                {
                    ClaimantList = _dbContext.claimant.FromSqlRaw(_query.GetClaimantById(Claimantid)).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return ClaimantList;
        }
        public Claimant CreateClaimant(Claimant Claimant)
        {
            if (Claimant != null)
            {
                try
                {
                    _dbContext.claimant.Add(Claimant);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }
            return Claimant;
        }
    }
}

