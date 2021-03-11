using Passengers.BAL.Interface;
using Passengers.DAL.Repository;
using Moq;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment_1.Controllers;
using Passengers.Models;
using Xunit;
using System.Web.Mvc;
using System.Web.Http.Results;
using System.Web.Http;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Passengers.Test
{
    public class TestController
    {
        private readonly Mock<ICustomerDetail> mockData = new Mock<ICustomerDetail>();

        private readonly CustomerController _customerController;
        public TestController()
        {
            _customerController = new CustomerController(mockData.Object);

        }


        [Fact]
        public void OK_GetCustomerList()
        {
            var result = mockData.Setup(m => m.GetCustomerList()).Returns(GetCustomer());
            var response = _customerController.Get();
            Assert.Equal(4, response.Count);
        }
        [Fact]
        public void NotOK_GetCustomerList()
        {
            var result = mockData.Setup(m => m.GetCustomerList()).Equals(null);
            var response = _customerController.Get();
            Assert.Null(response);
        }
        [Fact]
        public void OK_AddNewCustomer()
        {
            var newUser = new Customer();
            newUser.Id = 1;
            newUser.f_name = "abc";
            newUser.l_name = "xyz";
            newUser.phone_no = "1234567890";
            var response = mockData.Setup(m => m.AddNewCustomer(newUser)).Returns(AddCustomer());
            var result = _customerController.Post(newUser);
            Assert.NotNull(result);
        }
        [Fact]
        public void NotOK_AddNewCustomer()
        {
            var newUser = new Customer();
            newUser.Id = 1;
            newUser.f_name = null;
            newUser.l_name = null;
            newUser.phone_no = null;
            var response = mockData.Setup(m => m.AddNewCustomer(newUser)).Equals(null);
            var result = _customerController.Post(newUser);
            Assert.Null(result);
        }
        [Fact]
        public void OK_UpdateCustomer()
        {
            var model = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("UpdateData/customer.json"));
            var resultObj = mockData.Setup(m => m.UpdateCustomer(model, model.Id)).Returns(model);
            var response = _customerController.Put(model, model.Id);
            Assert.Equal(model, response);
        }
        [Fact]
        public void NotOK_UpdateCustomer()
        {
            var model = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("UpdateData/customer.json"));
            var resultObj = mockData.Setup(m => m.UpdateCustomer(model, model.Id)).Equals(null);
            var response = _customerController.Put(model, model.Id);
            Assert.NotEqual(model, response);
        }
        [Fact]
        public void OK_DeleteCustomer()
        {
            var customer = new Customer();
            customer.Id = 1;
            var resultObj = mockData.Setup(m => m.DeleteCustomer(customer.Id)).Returns(true);
            var response = _customerController.Delete(customer.Id);
            Assert.True(response);
        }
        [Fact]
        public void NotOK_DeleteCustomer()
        {
            var customer = new Customer();
            customer.Id = 1;
            var resultObj = mockData.Setup(m => m.DeleteCustomer(customer.Id)).Returns(false);
            var response = _customerController.Delete(customer.Id);
            Assert.False(response);
        }
        private static IList<Customer> GetCustomer()
        {
            IList<Customer> customer = new List<Customer>()
            {
                new Customer() { Id = 1, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
                new Customer() { Id = 2, f_name = "pqr", l_name = "xyz", phone_no = "2222222222" },
                new Customer() { Id = 3, f_name = "abc", l_name = "xyz", phone_no = "1111111111" },
                new Customer() { Id = 4, f_name = "pqr", l_name = "xyz", phone_no = "2222222222" }
            };
            return customer;
        }
        private static Customer AddCustomer()
        {
            var newUser = new Customer();
            newUser.Id = 1;
            newUser.f_name = "abc";
            newUser.l_name = "xyz";
            newUser.phone_no = "9685741210";
            return newUser;
        }



    }
}
