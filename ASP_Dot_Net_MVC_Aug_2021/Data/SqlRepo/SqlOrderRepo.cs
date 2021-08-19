using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.SqlRepo
{
    public class SqlOrderRepo : IOrderRepo
    {
        private readonly AppDbContext _context;

        public SqlOrderRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(Order input)
        {
            if (input == null)
                throw new ArgumentException(nameof(input));

            _context.Orders.Add(input);
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(v => v.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateOrder(Order input)
        {
            var itemInTheList = _context.Orders
                .FirstOrDefault(i => i.Id == input.Id);

            if (itemInTheList != null)
            {
                itemInTheList.Name = input.Name;
                itemInTheList.Date = input.Date;
            }
        }
    }
}
