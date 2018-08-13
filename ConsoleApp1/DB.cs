using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Other
    {
        public int Id { get; set; }
    }

    public class Item : Other
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }

    public class SomeProduct : Item
    {
        public ICollection<Characteristic> Characteristics { get; set; }
    }

    public class Characteristic : Other
    {
        public string CharName { get; set; }
        public ICollection<string> Charact { get; set; }
    }

    public class Reiews : Other
    {
        public string UserName { get; set; }
        public double Rating { get; set; }
        public string Text { get; set; }
        public string FeedbackEmail { get; set; }
    }


}
