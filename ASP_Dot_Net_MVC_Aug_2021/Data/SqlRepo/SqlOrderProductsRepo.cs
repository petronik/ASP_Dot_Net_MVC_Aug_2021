using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.SqlRepo
{
    public class SqlOrderProductsRepo : IOrderProductsRepo
    {
        private readonly AppDbContext _context;

        public SqlOrderProductsRepo(AppDbContext context)
        {
            _context = context;
        }



        public void CreateOrderProducts(OrderProducts input)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderProducts(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderProducts> GetAllOrderProducts()
        {
            return _context.OrderProducts.ToList();
        }

        public OrderProducts GetOrderProductsById(int id)
        {
            throw new NotImplementedException();
        }



        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateOrderProducts(OrderProducts input)
        {
            throw new NotImplementedException();
        }




        public void AddRange(IEnumerable<OrderProducts> range)
        {
            _context.AddRange(range);
        }

        public void RemoveRange(int orderId)
        {
            var rangeToRemove = _context.OrderProducts
                .Where(op => op.OrderId == orderId);
            _context.RemoveRange(rangeToRemove);
        }
    }
}
