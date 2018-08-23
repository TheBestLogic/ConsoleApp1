using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item : BaseClass
    {
        public string Name { get; set; }
        public string Company { get; set; }

        protected Item()
        {
            Name = "Name";
            Company = "Company";
        }

        /*public Item(int id, string name, string company) : base(id)
        {
            Name = name;
            Company = company;
        }*/
    }
}
