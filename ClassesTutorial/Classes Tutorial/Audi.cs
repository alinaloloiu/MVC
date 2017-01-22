using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    class Audi:Car
    {
        public int Vitezometru( int acceleratie)
        {
            if (acceleratie == 1)
            return 1;

            else if  (acceleratie == 2)
            return 50;

            else if (acceleratie == 3)
            return 100;

            else if (acceleratie == 0)
            return 0;

            return 0;
        }
    }
}
