using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces
{
    public interface IOrderProductsRepo
    {
        IEnumerable<OrderProducts> GetAllOrderProducts();
        OrderProducts GetOrderProductsById(int id);
        void CreateOrderProducts(OrderProducts input);
        void UpdateOrderProducts(OrderProducts input);
        void DeleteOrderProducts(int id);

        bool SaveChanges();
        void RemoveRange(int orderId);
        void AddRange(IEnumerable<OrderProducts> range);
    }
}
