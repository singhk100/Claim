using Claim.ClaimDBContext;
using Claim.Interfaces;
using Claim.Models;
using Claim.ViewModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Claim.Repository
{
    public class GenericRepository : IGenericRepository
    {
        readonly ClaimsDBContext _dbContext = new();

        public GenericRepository(ClaimsDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<GenericVM> GetGeneric(List<GenericVM> json)
        {
            List<GenericVM> genericList = new();

            if (json != null)
            {
                string genericQuery = $@"SELECT * FROM CUSTOMER ";
                var customerList = _dbContext.customer.FromSqlRaw(genericQuery).ToList();

                foreach (GenericVM obj in json)
                {

                    bool isCustomerExists = customerList.Where(c=> c.MobileNumber == obj.MobileNumber && c.PolicyHolderName.ToLower().Trim() == obj.Name.ToLower().Trim()).Any();


                    if (isCustomerExists)
                    {
                        //obj.PolicyName = customerList.Select(x => x.policyName);
                        genericList.Add(obj);
                    }
                }
                foreach (GenericVM obj in genericList)
                {
                    var list = customerList.Where(c => c.MobileNumber == obj.MobileNumber && c.PolicyHolderName.ToLower().Trim() == obj.Name.ToLower().Trim()).Select(c=>c.policyName);
                    obj.PolicyName = list.First();
                    var list1 = customerList.Where(c => c.MobileNumber == obj.MobileNumber && c.PolicyHolderName.ToLower().Trim() == obj.Name.ToLower().Trim()).Select(c => c.SumAssured);
                    obj.SumAssured = list1.First();

                }
            }
            
            return genericList;
        }
    }
}
