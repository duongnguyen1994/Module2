using System;
using System.Collections.Generic;
using System.Text;

namespace TH_ClassAnimal_InterfaceEdible
{
    class Chicken:Animal,IEdible
    {
        public override string MakeSound()
        {
            return "cluck-cluck";
        }
        public string HowToEat()
        {
            return "Throw to hot water in 10 minutes";
        }
    }
}
