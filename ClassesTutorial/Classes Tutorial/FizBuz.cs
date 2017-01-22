using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    class FizBuz
    {


        public static string ShowFizBuz(int retnr)
        {
            if (retnr % 15 == 0) { return "Fiz Buzz"; }
            if (retnr % 3 == 0) { return "Fiz Buzz"; }
            if (retnr % 5 == 0) { return "Fiz Buzz"; }
            else { return "" + retnr; }

        }
    }
}
