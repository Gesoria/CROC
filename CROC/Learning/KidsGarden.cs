using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{
    public class KidsGarden

    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Coast { get; set; }
        public string DayTime { get; set; }

        public KidsGarden(string name, string adress, string coast, string daytime)
        {
            Name = name;
            Adress = adress;
            Coast = coast;
            DayTime = daytime;

        }

        public Human AddInKidsGarden(Human anyanya)
        {
            Console.WriteLine($"В детский сад {Name} по адресу {Adress} приполз {anyanya.FirstName} {anyanya.SecondName} и САМОСТОЯТЕЛЬНО(!!!) заплатил {Coast} таджикских сомани... ");
            return anyanya;
        }





    }
}
