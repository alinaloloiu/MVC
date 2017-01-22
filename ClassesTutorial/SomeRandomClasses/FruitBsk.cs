using Classes_Tutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeRandomClasses
{
    public class FruitBsk
    {
        public List<Fruit> listafructe;

        public FruitBsk()
        {
            FruitBsk fr = new FruitBsk();
            
        }

        public void AddFruit(Fruit fruit)
        {
            listafructe.Add(fruit);

        }
        public void DisplayFruitCalories()
        {
            foreach (var f in listafructe)
            {
                Console.WriteLine(f.GetCalories);
            }

        }


    }
}