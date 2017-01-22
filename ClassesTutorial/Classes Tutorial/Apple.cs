using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    class Apple:Fruit
    {
        string color;
        public Apple()
        { Console.WriteLine("An apple has been created"); }

        public override int GetCalories()
        {
            return 2;
        }

    }
}
