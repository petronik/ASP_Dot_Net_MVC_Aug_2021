using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces
{
    public interface IItemRepo
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(int id);
        void CreateItem(Item input);
        void UpdateItem(Item input);
        void DeleteItem(int id);

        bool SaveChanges();
    }
}
