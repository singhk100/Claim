using Claim.Interfaces;
using Claim.ClaimDBContext;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using Claim.Models;
using Claim.ClaimDBContext;
using System.Security.Claims;

namespace Claim.Repository
{
    public class ClaimsRepository : IClaimsRepository
    {
        readonly ClaimsDBContext _dbContext = new();
        readonly IQuery _query;
        //public ClaimsRepository()
        //{

        //}
        public ClaimsRepository(ClaimsDBContext dbContext,Query query)
        {
            _dbContext = dbContext;
            _query = query;
        }

        public List<Claims> GetClaimDetails(int claimid = 0)
        {
            List<Claims> claimList = new List<Claims>();
            try
            {
                if (claimid == 0)
                {
                    claimList = _dbContext.claims.FromSqlRaw(_query.GetClaims()).ToList();
                }
                else
                {
                    claimList = _dbContext.claims.FromSqlRaw(_query.GetClaimsById(claimid)).ToList();
                }
            }
            catch
            {
                Console.WriteLine("ex");
                throw;
            }
            return claimList;
        }
        public Claims CreateClaim(Claims claim) 
        {
            if(claim != null)
            {
                try
                {
                    _dbContext.claims.Add(claim);
                    _dbContext.SaveChanges();
                } 
                catch(Exception ex)
                {
                    Console.WriteLine("ex");
                    throw;
                }
               
            }
            return claim;
        }
    }
}
