using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // NuGet
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

        /*public void Add(Product product)
          {
              throw new NotImplementedException();
          }
          public void Delete(Product product)
          {
              throw new NotImplementedException();
          }
          public Product Get(Expression<Func<Product, bool>> filter)
          {
              throw new NotImplementedException();
          }
          public List<Product> GetAll()
          {
              //return new List<Product> { new Product { ProductName = "Tablo" }, new Product  }
              return GetAll();

          }
          public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
          {
              throw new NotImplementedException();
          }
          public List<Product> GetAllByCategory(int categoryId)
          {
              throw new NotImplementedException();
          }
          public void Update(Product product)
          {
              throw new NotImplementedException();
          }*/
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {   ProductId = p.ProductId, 
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
