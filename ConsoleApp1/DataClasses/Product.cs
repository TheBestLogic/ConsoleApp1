using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product : Item
    {
        public Media MediaFiles;
        public ICollection<ProductToCharacteristic> ProductToCharacteristics { get; set; } = new List<ProductToCharacteristic>();

        public Product() => ProductToCharacteristics = new List<ProductToCharacteristic>();

        /*public Product(int id, string name, string company, Characteristic characteristics) : base(id, name, company)
        {
            Characteristics.Add(characteristics);
        }

        public Product(int id, string name, string company, List<Characteristic> characteristics) : base(id, name, company)
        {
            Characteristics = characteristics;
        }*/

        /*public SomeProduct(int id, string name, string company, ICollection<Characteristic> characteristics) : base(id, name, company)
        {
            Characteristics = characteristics;
        }*/
    }
}
