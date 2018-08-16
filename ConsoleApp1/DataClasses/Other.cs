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

        protected Other()
        {
            
        }

        public Other(int inId)
        {
            Id = inId;
        }
    }
}
