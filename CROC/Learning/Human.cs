using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{
    public class Human
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string City { get; set; }
        public string Zodiac { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public double ChlenOrBoobs { get; set; }
        public string Taboo { get; set; }

        public Human(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;

        }
        public void AddInformation(string city, string zodiac, int age, int height, int weight, double chlenorboobs, string taboo)
        {
            City = city;
            Zodiac = zodiac;
            Age = age;
            Height = height;
            Weight = weight;
            ChlenOrBoobs = chlenorboobs;
            Taboo = taboo;

        }
        //public void Kyshatb(Food jralovo)
        //{
        //    Console.WriteLine($"{FirstName} {SecondName} поглощает {jralovo.KKal} {jralovo.Name} );
        //}
    }

}
