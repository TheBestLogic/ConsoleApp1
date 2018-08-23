using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Characteristic : BaseClass
    {
        public string CharactericticName { get; set; }
        public string CharactericticText { get; set; }

        public Characteristic()
        {
            CharactericticName = "CharactericticName";
            CharactericticText = "CharactericticText";
        }

        /*public Characteristic(int id, string charName, string charText) :base(id)
        {
            Id = id;
            CharName = charName;
            CharText = charText;
        }*/
    }
}
