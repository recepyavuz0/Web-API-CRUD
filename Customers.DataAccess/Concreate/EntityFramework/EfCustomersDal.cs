using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCustomersDal : ICustomersDal
    {
        
        public void Add(Customers customer)
        {
            using (CustomersDbContext customersDbContext = new CustomersDbContext())
            {
                var add = customersDbContext.Entry(customer);
                add.State = EntityState.Added;
                customersDbContext.SaveChanges();
            }
        }

        public void Delete(Customers customer)
        {
            using (CustomersDbContext customersDbContext = new CustomersDbContext())
            {
                var del = customersDbContext.Entry(customer);
                del.State = EntityState.Deleted;
                customersDbContext.SaveChanges();
            }
        }

        public List<Customers> GetAll()
        { 
            using (CustomersDbContext customersDbContext = new CustomersDbContext())
            {
                return customersDbContext.Customers.ToList();
            }
        }

        public List<Customers> GetCustomersById(int id)
        {
            using (CustomersDbContext customersDbContext = new CustomersDbContext())
            {
                return (from c in customersDbContext.Customers
                        where c.ID == id
                        select c).ToList();
            }
        }

        public void Update(Customers customer)
        {
            using(CustomersDbContext customersDbContext =new CustomersDbContext()) 
            {
                var update = customersDbContext.Entry(customer);
                update.State = EntityState.Modified;
                customersDbContext.SaveChanges();
            }
        }
    }
}
