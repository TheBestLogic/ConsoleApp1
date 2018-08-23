using System;
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
                Product Prod1 = new Product(1, "Phone", "company",new Characteristic( 1, "name","descr"));
                Product Prod2 = new Product(2, "NotPhone", "company", new List<Characteristic> { new Characteristic(2, "3234", "wfwef"), new Characteristic(3, "3234", "wfwef"), new Characteristic(4, "3234", "wfwef") });

                


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
