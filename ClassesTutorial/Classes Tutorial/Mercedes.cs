using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    public class Mercedes: AbstractCar
    {

        private string to_description;
        private int to_price;
        private int counter;
       // public static counter2;
 

        public void PrintMercedesLogo()
        {
            Console.WriteLine("This is from Mercedes");
           
            if (counter == 3)
            { return;
                PrintMercedesLogo();
                counter++;
            }
        }


        public double ShowRemainingNoOfKM(double noOfFuelLiters, double
            Consumption)

        {
            double result = 0;
            result = noOfFuelLiters / Consumption * 100;

            return result;
        }

        public void PrintNewMercedes(int c)
        {
            if (c==3)
            {
                return;
            }
            Console.WriteLine("Mercedes No." + c);

        }

        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }


        public int MyProperty { get; set; } 
        public Mercedes(int n)
        {
        }

        internal Mercedes()
        {
        }

        internal string Description
        {
            get{ return to_description; }
            set { to_description = value; }
        }

        internal int Price
        {
            get{ return to_price; }
            set { to_price = value; }
 
        }       


        public static void StartEngine()
        {

        }

        public static void StartEngine(int sec)
        {
            Console.WriteLine("The cr is starting in " +sec +" sec");
        }



    }
}
