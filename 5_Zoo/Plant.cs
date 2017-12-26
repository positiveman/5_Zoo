using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    abstract class Plant : AliveEntety
    {
        public int Height { get; set; }
        public abstract void Growth();
    }
}
