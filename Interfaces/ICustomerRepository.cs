using Claim.Models;

namespace Claim.Interfaces
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomerDetails(int customerId = 0);
        public Customer CreateCustomer(Customer customer);

    }
}
