using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetALL()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetALL(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByAllCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetByAllCategory(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
