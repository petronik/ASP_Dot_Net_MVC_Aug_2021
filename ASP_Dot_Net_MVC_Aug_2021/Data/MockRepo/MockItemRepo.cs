using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.MockRepo
{
    public class MockItemRepo : IItemRepo
    {
        private readonly static List<Item> _items = new List<Item> { 
        
            new Item { Id = 101, Name = "Boiled water", Price = 15.55 },
            new Item { Id = 102, Name = "Fresh stones", Price = 19.99 },
            new Item { Id = 103, Name = "White paper", Price = 2.22 },
        };

        public void CreateItem(Item input)
        {
            _items.Add(input);
        }

        public void DeleteItem(int id)
        {
            var itemToDelete = _items.FirstOrDefault(i => i.Id == id);

            if (itemToDelete != null)
                _items.Remove(itemToDelete);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _items;
        }

        public Item GetItemById(int id)
        {
            return _items.FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item input)
        {
            var itemInTheList = _items.FirstOrDefault(i => i.Id == input.Id);

            if (itemInTheList != null)
            {
                // itemToUpdate = input; // THE BUG!!!!!!!!!!

                /*
                _items.Remove(itemInTheList);
                _items.Add(input);
                _items.Sort((a, b) => (a.Id).CompareTo(b.Id));
                */

                itemInTheList.Name = input.Name;
                itemInTheList.Price = input.Price;
            }
        }
    }
}
