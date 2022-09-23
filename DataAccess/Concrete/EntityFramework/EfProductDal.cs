using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        //public void Add(Product entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Product entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product Get(Expression<Func<Product, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Product entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
