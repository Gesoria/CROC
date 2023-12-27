using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{

    public class BabySpawn
    {
        public string Adress { get; set; }

        public BabySpawn(string adress)
        {
            Adress = adress;
        }
        public Human BabyBorn(string Date, string FirstName, string SecondName)
        {
            Human chel = new Human(FirstName, SecondName);
            Console.WriteLine($" {Date} В роддоме по адресу {Adress} родился необычный малыш по имени {FirstName} {SecondName}!!!!=)");
            return chel;
        }
    }

}
