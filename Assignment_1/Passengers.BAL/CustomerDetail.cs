using Passengers.BAL.Interface;
using Passengers.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passengers.Models;

namespace Passengers.BAL
{
    public class CustomerDetail : ICustomerDetail
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerDetail(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer AddNewCustomer(Customer model)
        {
            return _customerRepository.AddNewCustomer(model);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public IList<Customer> GetCustomerList()
        {
            return _customerRepository.GetCustomerList();
        }

        public Customer UpdateCustomer(Customer model, int id)
        {
            return _customerRepository.UpdateCustomer(model, id);
        }
    }
}
