using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{
    public class TinderUser
    {
        public string Name { get; set; }
        public string Home { get; set; }
        public string Zodiac { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public int MaxScumDamage { get; set; }
        public int MinScumDamage { get; set; }
        public int FullScumPoints { get; set; }

        public bool LiveFromScum = true;


        public TinderUser(string name, string home, string zodiac, string age, string height, int maxscumd, int minscumd, int fullscumpoints)
        {
            Name = name;
            Home = home;
            Zodiac = zodiac;
            Age = age;
            Height = height;
            MaxScumDamage = maxscumd;
            MinScumDamage = minscumd;
            FullScumPoints = fullscumpoints;

            Console.WriteLine($"{Name} из {Home}, возраст {Age}, рост {Height}, знак зодиака {Zodiac} хочет просто чтоб ему положили пожрать И ТРАХНУТЬ КОГО-НИБУДЬ В ЖОПУ!!!");

        }
        public void ScumAttack(TinderUser anotherUser)
        {
            Random random = new Random();

            int zalupa = random.Next(MinScumDamage, MaxScumDamage);

            if (LiveFromScum)
            {
                Console.WriteLine($"{anotherUser.Name} скамит профиль {Name} на {zalupa}/10!!");
                anotherUser.AcceptScumDamage(this, zalupa);
            }
        }
        public void AcceptScumDamage(TinderUser anotherUser, int ScumPoEbalu)

        {
            FullScumPoints -= ScumPoEbalu;

            if (FullScumPoints > 0)
            {
                Console.WriteLine($"{Name} заскамился от {anotherUser.Name} на {ScumPoEbalu}/10 и его скам-терпение составляет {FullScumPoints}!! =(");

            }
            else
            {
                LiveFromScum = false;
                Console.WriteLine($"{Name} умер от фуллскама и удалил профиль в тиндере)))))))");
            }
        }


    }

}
