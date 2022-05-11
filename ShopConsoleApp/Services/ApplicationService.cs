using ShopConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsoleApp.Services
{
    public class ApplicationService
    {
        private ShopService _shopService;

        public ApplicationService()
        {
            _shopService = new ShopService();
        }

        public void Process(string command)
        {
            

            if (command.StartsWith("Add"))
            {
                if(command.EndsWith("Add"))
                {
                    Console.WriteLine("Inccorect command");
                }

                else
                {
                    string[] splitCommand = command.Split(" ");
                    _shopService.Add(splitCommand[1], splitCommand[2]);
                }
             
            }

            else if (command.StartsWith("Remove"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Remove(splitCommand[1]);
            }

            else if (command.StartsWith("Show"))
            {
                List<ShopItem> items = _shopService.GetAll();
                foreach (ShopItem item in items)
                {
                    Console.WriteLine($"ItemName: {item.Name} ItemQty: {item.Quantity}");
                }
            }

            else if (command.StartsWith("Set"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Set(splitCommand[1], splitCommand[2]);
            }

            else if (command.StartsWith("Exit"))
            {
                Environment.Exit(1);
                
            }

            else
            {
                Console.WriteLine("Inccorect command");
            }
        }
    }
}
