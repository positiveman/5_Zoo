using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Zoo
{
    class Human : Animal
    {
        protected Human()
        {
        }

        public override string Name { public get; private set; }
        public override int Age { get; set; }

        public override void Say()
        {
            throw new NotImplementedException();
        }
    }
}
