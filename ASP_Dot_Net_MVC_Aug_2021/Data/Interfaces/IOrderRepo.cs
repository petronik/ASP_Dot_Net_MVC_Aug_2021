using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces
{
    public interface IOrderRepo
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void CreateOrder(Order input);
        void UpdateOrder(Order input);
        void DeleteOrder(int id);

        bool SaveChanges();
    }
}
