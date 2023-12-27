using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Zoo
{
    public class Sobachki : Animal
    {
        
        /// <summary>
        /// Description это типа порода псины =)
        /// </summary>
        public string Description { get; set; }
        public int Age { get; set; }
               
        public string LovelyFood { get; set; }
        public int Amountofchildren { get; set; }

        public Sobachki( string name, string description, int age, bool female, int weight, string lovelyfood, int amountofchldren )

        {
            Name = name;
            Description = description;
            Age = age;
            Female = female;
            Weight = weight;
            LovelyFood = lovelyfood;
            Amountofchildren = amountofchldren;

        }
        public void RezatLapki()
            
        {
            if (Age <= 2)
            {
                Console.WriteLine($"Sobachke po klichke {Name} mojno otrezat' malen'kie milen'kie pushistie lapki (mLEN'KIM NOJICHKOM)");
            }
            else 
            {
                Console.WriteLine($"Y sobachi slishkom starie i napushistie lapki,  chtobi ih otrezat'( ");

            }
            if (LovelyFood == "kaki")
            {
                Console.WriteLine($"{Name} mojno otrezat' lapki za poedanie kakov");

            }
            else 
            {
                Console.WriteLine("Ladno ya zaebalas' pisat' ");
            }
            
        }



    }
}
