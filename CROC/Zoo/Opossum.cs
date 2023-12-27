using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Zoo
{
    public class Opossum : Animal

    {
        
        public double Age { get; set; }
       
       
        public string LovelyFood { get; set; }
        public int Amountofchildren { get; set; }

        public const int StandartMealWeight = 10;


        public Opossum(string name, double age, bool female, int weight, string lovelyfood, int amountofchildren)

        {
            Name = name;
            Age = age;
            Female = female;
            Weight = weight;
            LovelyFood = lovelyfood;
            Amountofchildren = amountofchildren;

        }
        public static void AboutOpussums()
        {
            Console.WriteLine("Opossumi milie malen'rkie vonuchki");
        }
        public void CalculateAmountOfFood()

        {
            int mealweight = StandartMealWeight;

            if (Female == true)
            {
                switch (Amountofchildren)
                {
                    case 0:
                        break;
                    case 1:
                        mealweight += 2;
                        break;
                    case 2:
                        mealweight += 4;
                        break;
                    case 3:
                        mealweight += 6;
                        break;
                    case 4:
                        mealweight += 8;
                        break;
                    case 5:
                        mealweight += 10;
                        break;
                    default: mealweight += 100;
                        break;
                }
              
            }
            else 
            {
                mealweight *= 2;
            }
            Console.WriteLine($"Opossmu po clichke {Name} nujno nasipat' {mealweight} g korma");
            

        }
        public void Spat() 
        {
            Console.WriteLine($"Opossum po klichke {Name} leg spat' i usnul vechnim snom (mama Dinara sorry)");

        }

    }
}
