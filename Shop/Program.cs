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

            foreach (Grocery item in w)
            {
                item.Info();
            }
        }
    }
}
