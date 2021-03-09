using Entities.Concreate;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomersServices
    {
        List<Customers> GetAll();
        List<Customers> GetCustomersById(int id);
        void Add(Customers customer);
        void Update(Customers customer);
        void Delete(Customers customer);
    }
}
