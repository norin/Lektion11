using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion11.Data.Entities;

namespace Lektion11.Data.Abstract
{
    public interface IProductRepository
    {
        void Save(Product product);
        void Delete(Product product);
        Product Get(int id);
        IQueryable<Product> GetProducts(int skip = 0, int? take = null, Func<Product, bool> filter = null);
    }
}
