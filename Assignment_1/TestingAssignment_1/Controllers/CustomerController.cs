using Passengers.BAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Passengers.Models;

namespace TestingAssignment_1.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerDetail _customerDetail;
        public CustomerController(ICustomerDetail customerDetail)
        {
            _customerDetail = customerDetail;
        }

        [Route("api/Customer")]
        [HttpGet]
        public IList<Customer> Get()
        {
            var data = _customerDetail.GetCustomerList();
            if (data != null)
            {
                return data;
            }
            return null;
        }

        [Route("api/Customer/AddNewCustomer")]
        [HttpPost]
        public Customer Post(Customer model)
        {

            if (ModelState.IsValid)
            {
                var dataObj = _customerDetail.AddNewCustomer(model);
                if (dataObj != null)
                {
                    return dataObj;
                }
            }
            return null;
        }

        [Route("api/Customer/UpdateCustomer")]
        [HttpPut]
        public Customer Put(Customer model, int id)
        {
            var data = ModelState.IsValid;
            if (data == true)
            {
                return _customerDetail.UpdateCustomer(model, id);
            }
            return null;
        }

        [Route("api/Customer/DeleteCustomer")]
        [HttpDelete]
        public bool Delete(int id)
        {
            var dataObj = _customerDetail.DeleteCustomer(id);
            if (dataObj == true)
            {
                return true;
            }
            return false;
        }
    }
}
