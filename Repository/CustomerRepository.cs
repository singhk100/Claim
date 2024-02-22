using Claim.ClaimDBContext;
using Claim.Interfaces;
using Claim.Models;
using Microsoft.EntityFrameworkCore;

namespace Claim.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly ClaimsDBContext _dbContext = new();
        readonly IQuery _query;

        public CustomerRepository(ClaimsDBContext dbContext, Query query)
        {
            _dbContext = dbContext;
            _query = query;
        }

        public List<Customer> GetCustomerDetails(int customerid = 0)
        {
            List<Customer> CustomerList = new List<Customer>();
            try
            {
                if (customerid == 0)
                {
                    CustomerList = _dbContext.customer.FromSqlRaw(_query.GetCustomer()).ToList();
                }
                else
                {
                    CustomerList = _dbContext.customer.FromSqlRaw(_query.GetCustomerById(customerid)).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return CustomerList;
        }
        public Customer CreateCustomer(Customer customer)
        {
            if (customer != null)
            {
                try
                {
                    _dbContext.customer.Add(customer);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }
            return customer;
        }
    }
}
