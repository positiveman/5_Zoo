using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    abstract class Animal: AliveEntety

    {
        public string name { get; set; }
        public abstract void Say();

    }
}
