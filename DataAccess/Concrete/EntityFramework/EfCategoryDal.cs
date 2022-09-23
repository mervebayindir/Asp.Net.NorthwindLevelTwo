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
    public class EfCategoryDal :EfEntityRepositoryBase<Category,NorthwindContext>, ICategoryDal
    {
        //public void Add(Category entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Category entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Category Get(Expression<Func<Category, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Category entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
