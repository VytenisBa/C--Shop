using ShopConsoleApp.Services;
using System;

namespace ShopConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var applicationService = new ApplicationService();

            while (true)
            {
                Console.WriteLine("Enter command:");
                var command = Console.ReadLine();

                applicationService.Process(command);
            }
            
        }
    }
}
