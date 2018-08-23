using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductToCharacteristic
    {
        public int ProductID { get; set; }
        public int CharactericticID { get; set; }
        public string CharactericticName { get; set; }

        public ProductToCharacteristic()
        {
            CharactericticName = "CharactericticName";
        }
    }
}
