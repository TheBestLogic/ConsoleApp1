using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SomeProduct : Item
    {
        public ICollection<Characteristic> Characteristics { get; set; }

        //public SomeProduct() => Characteristics. = new ICollection<Characteristic>();

        public SomeProduct(int id, string name, string company, Characteristic characteristics) : base(id, name, company)
        {
            Characteristics.Add(characteristics);
        }

        public SomeProduct(int id, string name, string company, List<Characteristic> characteristics) : base(id, name, company)
        {
            Characteristics = characteristics;
        }

        public SomeProduct(int id, string name, string company, ICollection<Characteristic> characteristics) : base(id, name, company)
        {
            Characteristics = characteristics;
        }
    }
}
