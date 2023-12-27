using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CROC.Zoo
{ public enum Description
    {
        Сфинкс,
        Шотландская_Гнида,
        Уличная_Тварь,
        Персидское_Ебло,
        Русская_Голубая_Шалава,
        Абиссинская_Сука,
        Боботейл_С_Отрезанным_Хвостиком,

    }
    public class Cats : Animal
    {
        public Description Poroda { get; set; }
        public int Age { get; set; }
        public string LovelyFood { get; set; }
        public int Amountofchildren { get; set; }

        public Cats (string name, Description poroda, int age, bool female, int weight, string lovelyfood, int amountofchldren) 

        {
            Name = name;
            Poroda = poroda;
            Age = age;
            Female = female;
            Weight = weight;
            LovelyFood = lovelyfood;
            Amountofchildren = amountofchldren;
        }
        public static void LizatSherstky()
        {
            Console.WriteLine($"Все котики любят вылизывать свою шкурочку, а потом рыгать на пол =)");
        }
        public void Linka()
        {
            if (Poroda != Description.Сфинкс )
            {
                Console.WriteLine($"{Name} породы {Poroda} линяет как гнида, сучью шерсть можно найти даже у себя в трусишках");
            }
            else
            {
                Console.WriteLine($"Наконец-то {Name} это нормальный лысый котяра, {Poroda} лучшая порода");
            }
        }
        public void KolichestvoKakov()
        {
            if (Female == false) 
            {
                if (Weight >= 5)
                {
                    Console.WriteLine($"{Name} делает очень много каков, потому что весит аж {Weight} кг и является настоящим мужицким котом");
                }
                else 
                {
                    Console.WriteLine($" {Name} делает маленькие мужские каки, потому что его {Weight} кг недостаточно для нормальной кучи дерьма =)");
                }
                
            }
            else
            {
                Console.WriteLine($"{Name} делает микро-каки");
            }

        }


    }


}
