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
                // создаем два объекта User
                Smartphone user1 = new Smartphone ();
                Smartphone user2 = new Smartphone ();

                // добавляем их в бд
                db.Smartphons.Add(user1);
                db.Smartphons.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                
            }
            Console.Read();
        }
    }
}
