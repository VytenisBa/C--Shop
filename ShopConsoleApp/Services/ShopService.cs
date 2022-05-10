using ShopConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsoleApp.Services
{
    public class ShopService
    {
        private List<ShopItem> _items;

        public ShopService()
        {
            _items = new List<ShopItem>();
        }



        public void Add(string name, string qty)
        {
            var item = new ShopItem()
            {
                Name = name,
                Quantity = qty
            };
            _items.Add(item);
        }

        public void Remove(string name)
        {
            _items = _items.Where(i => i.Name != name).ToList();
        }

        public List<ShopItem> GetAll()
        {
            return _items;
        }

        public void Set()
        {

        }
    }
}
