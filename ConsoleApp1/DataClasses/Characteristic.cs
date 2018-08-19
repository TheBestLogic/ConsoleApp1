using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Characteristic : Other
    {
        public string CharName { get; set; }
        public string CharText { get; set; }

        public Characteristic(int id, string charName, string charText)
        {
            Id = id;
            CharName = charName;
            CharText = charText;
        }
    }
}
