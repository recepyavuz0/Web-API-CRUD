using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class CustomersManager : ICustomersServices
    {
        ICustomersDal _customersDal;

        public CustomersManager(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        public void Add(Customers customer)
        {
            _customersDal.Add(customer);
        }

        public void Delete(Customers customer)
        {
            _customersDal.Delete(customer);
        }

        public List<Customers> GetAll()
        {
            return _customersDal.GetAll();
        }

        public List<Customers> GetCustomersById(int id)
        {
            if (id > 0)
            {
                return _customersDal.GetCustomersById(id);
            }
            else
                throw new Exception("ID 1'den küçük olamaz.");
            
        }

        public void Update(Customers customer)
        {
            _customersDal.Update(customer);
        }
    }
}
