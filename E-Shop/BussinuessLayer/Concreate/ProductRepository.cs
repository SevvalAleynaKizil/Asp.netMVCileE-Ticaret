using BussinuessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinuessLayer.Concreate
{
    public class ProductRepository:GenericRepository<Product>
    {
        DataContext db=new DataContext();
        public List<Product> GetProductList()
        {
            return db.Products.Include("Category").ToList();
        }
        public List<Product> GetPopularProduct()
        {
            return db.Products.Include("Category").Where(x => x.Popular == true).Take(100).ToList();
        }
    }
}
