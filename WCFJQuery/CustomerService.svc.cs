using System.Collections.Generic;
using System.Linq;
using WCFJQuery.Model;

namespace WCFJQuery
{
    public class CustomerService : ICustomerService
    {
        public IQueryable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {FirstName = "Kalle", LastName = "Anka"},
                new Customer {FirstName = "Bosse", LastName = "Kofot"}
            };
            return customers.AsQueryable();
        }
    }
}
