using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbClass db = new DbClass())
            {
                Product Prod1 = new Product();
                Product Prod2 = new Product();

                


                // добавляем их в бд
                db.Products.Add(Prod1);
                db.Products.Add(Prod2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                
            }
            Console.Read();
        }
    }
}
