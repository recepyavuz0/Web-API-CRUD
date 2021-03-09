using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomersDal
    {
        List<Customers> GetAll();
        List<Customers> GetCustomersById(int id);
        void Add(Customers customer);
        void Update(Customers customer);
        void Delete(Customers customer);

    }
}
