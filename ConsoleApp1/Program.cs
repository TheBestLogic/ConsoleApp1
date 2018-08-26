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
                Product Prod = new Product();
                Characteristic Ch = new Characteristic();
                Reiews Rew = new Reiews();
                Media Med = new Media();
                ProductToCharacteristic PrToCh = new ProductToCharacteristic(Prod, Ch);


                // добавляем их в бд
                db.Products_.Add(Prod);
                db.Characteristics_.Add(Ch);
                db.Rewiews_.Add(Rew);
                db.Media_.Add(Med);
                db.ProductToCharacteristics_.Add(PrToCh);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                
            }
            Console.Read();
        }
    }
}
