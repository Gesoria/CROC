using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Zoo
{
    public class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public bool Female { get; set; }


        public static void SleepingMod(Animal[] animals) 
        {
            Console.WriteLine($"{animals} любят спать мирным сном");

        }
    }

}
