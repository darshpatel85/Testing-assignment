using Passengers.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passengers.Models;
using AutoMapper;

namespace Passengers.DAL.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly TestingAssignment_1Entities db;
        public CustomerRepository()
        {
            db = new TestingAssignment_1Entities();
        }

        public IList<Customer> GetCustomerList()
        {
            var entities = db.Customers.ToList();
            List<Customer> list = new List<Customer>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Customer customer = new Customer();
                    customer.f_name = item.f_name;
                    customer.l_name = item.l_name;
                    customer.phone_no = item.phone_no;
                    list.Add(customer);
                }
            }
            return list;
        }

        public Customer AddNewCustomer(Customer model)
        {

            Customers customers = new Customers();
            customers.f_name = model.f_name;
            customers.l_name = model.l_name;
            customers.phone_no = model.phone_no;
            db.Customers.Add(customers);
            db.SaveChanges();
            return model;
        }

        public Customer UpdateCustomer(Customer model, int id)
        {
            var customer = db.Customers.Find(id);

            customer.f_name = model.f_name;
            customer.l_name = model.l_name;
            customer.phone_no = model.phone_no;
            db.SaveChanges();
            return model;
        }

        public bool DeleteCustomer(int id)
        {
            var data = db.Customers.Find(id);
            if (data != null)
            {
                db.Customers.Remove(data);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
