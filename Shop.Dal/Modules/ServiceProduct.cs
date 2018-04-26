using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Dal.Modules
{
    public class ServiceProduct
    {
        private Random rand = new Random();
        public void GenerateProduct(Grocery shop)
        {
            for (int i = 0; i < rand.Next(5, 20); i++)
            {
                Product p = new Product();
                p.Barcode = rand.Next(10000, 30000);
                p.Cur.CurCode = 398;
                p.Cur.CurName = "KZT";
                p.DateOfProduction = DateTime.Now.AddDays(-rand.Next(0, 1000));
                p.ExpiredDay = rand.Next(1, 10);
                p.ExpiredTime = DateTime.Now.AddDays(rand.Next(0, 20));
                p.Name = string.Format("Product # {0}", rand.Next());
                p.Price = rand.NextDouble();
                shop.Products.Add(p);
            }
        }
        public List<Grocery> GenerateShop()
        {
            List<Grocery> Shops = new List<Grocery>();
            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                Grocery grocery = new Grocery();
                grocery.Name = "Shop #" + rand.Next();
                GenerateProduct(grocery);
                Shops.Add(grocery);
            }
            return Shops;
        }
    }
}
