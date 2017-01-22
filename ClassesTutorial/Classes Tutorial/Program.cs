using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{

    class Program
    {
        string nume;

        static void PrintLogo()
        {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C# is great!");
            PrintLogo2();
        }

        static void PrintLogo(int i )
        {
            Console.WriteLine("I am another PrintLogo");

        }

        static int counter;
        static void PrintLogo2()
        {
            
            Console.WriteLine("This is from Logo2");
            if (counter == 3)
                 { 
                    counter++;
                    PrintLogo2();
                    return;

            }
        }


       


            static void Main(string[] args)
        {
            // AbstractCar aCar = new AbstractCar(); 
            sbyte a = -127;

           
            AbstractCar car2 = new Mercedes(5);
            ICar car = new Mercedes(10);
          //  EngineStruct engine = new EngineStruct(); // instantiere str
            Mercedes mercedes = new Mercedes(); //creare instanta

            Console.WriteLine("Mercedes is " + mercedes.Description);
            Console.WriteLine("Mercedes is " + mercedes.Price);
            Console.WriteLine("This is my first C#");
            PrintLogo();
            PrintLogo(2);


            Mercedes m = new Mercedes();
            Mercedes m1 = new Mercedes();
            Mercedes m2 = new Mercedes();
            Mercedes m3 = new Mercedes();
            Mercedes m4 = new Mercedes();
            //m.PrintMercedesLogo();
            // m1.PrintNewMercedes(Mercedes.counter2++);
            // m2.PrintNewMercedes(Mercedes.counter2++);
            // m3.PrintNewMercedes(Mercedes.counter2++);
            // m4.PrintNewMercedes(Mercedes.counter2++);

            Mercedes.StartEngine();
            Mercedes.StartEngine(2);
            Console.WriteLine(m.ShowRemainingNoOfKM(1000, 10));
            Console.WriteLine(m.CalculateConsumption(2,10,3));


            double numberOfKmLeft;
            numberOfKmLeft = m.ShowRemainingNoOfKM(5000, 10);
            Console.WriteLine(numberOfKmLeft);
           

            Audi audi = new Audi();
            audi.CarStart();
            Console.WriteLine(audi.Vitezometru(2));

            Orange or = new Orange();
            Apple ap = new Apple();
            Fruit f = new Fruit();
            Joha j = new Joha();

            Console.WriteLine(j.GetCalories());
            Console.WriteLine(ap.GetCalories());
            Console.WriteLine(f.GetCalories());
            
            
            
            Console.ReadKey();
        }
    }
}
