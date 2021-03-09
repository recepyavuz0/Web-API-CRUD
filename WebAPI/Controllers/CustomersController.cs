using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomersServices _customersServices;

        public CustomersController()
        {
            _customersServices = new CustomersManager(new EfCustomersDal());
        }

        [HttpGet]
        public List<Customers> Get()
        {
            return _customersServices.GetAll();
        }

        [HttpGet("{id}")]
        public List<Customers> Get(int id)
        {
            return _customersServices.GetCustomersById(id);
        }

        [HttpPost]
        public void Post([FromBody]Customers customer)
        {
            _customersServices.Add(customer);
        }

        [HttpPut]
        public void Put([FromBody] Customers customer)
        {
            _customersServices.Update(customer);
        }

        [HttpDelete]
        public void Delete([FromBody] Customers customer)
        {
            _customersServices.Delete(customer);
        }
    }
}
