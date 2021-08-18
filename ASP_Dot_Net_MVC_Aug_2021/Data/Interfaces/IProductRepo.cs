using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
        void CreateProduct(Product input);
        Product GetProductById(string id);
        void UpdateProduct(Product input);
        bool SaveChanges();
    }
}
