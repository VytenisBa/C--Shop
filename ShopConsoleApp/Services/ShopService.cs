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
            //c + p
            //if(!_items.Any(x => x.Name == name))
            //{
            //    _items.Add(item);
            //}
           // else
               // Console.WriteLine("Inccorect command");
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

        //c+p
        public void Set(string name, string qty)
        {
            ShopItem firstShopItem = _items.First(i => i.Name == name);
            firstShopItem.Quantity = qty;
        }
    }
}
