using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Dal.Modules;


namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProduct service = new ServiceProduct();
            List<Grocery> w = service.GenerateShop();

            foreach (Grocery item in w.OrderBy(o => o.Products.Count()))
            {
                item.Info();
            }
            
            Console.WriteLine("Enter Shop name");
            string shop = Console.ReadLine();
            //Console.Clear();

            Grocery gross = w.FirstOrDefault(o => o.Name == shop);

            if (gross != null)
            {
                Console.WriteLine("Enter QR");
                int temp = Int32.Parse(Console.ReadLine());
                Product findProd = gross[temp];
                findProd.PrintInfo();
            }
        }
    }
}
