using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    class Joha:Apple
    {
        public Joha()
        { Console.WriteLine("An jona apple has been created"); }

        public override int GetCalories()
        {
            return 3;
        }
    }
}
