using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    public class Fruit
    {
        int fibres;

        public virtual int GetCalories()
        {
            return 1;
        }

       
        public Fruit()
        { Console.WriteLine("A fruit has been created"); }

    }
}
