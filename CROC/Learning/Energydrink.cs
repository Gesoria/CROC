using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{
    internal static class Energydrink
    {
        /// <summary>
        /// Функция принимает в себя сумму денег, которые у нас есть и печатает
        /// сколько энергетиков мы сможем купить
        /// </summary>
        internal static void PokypochkaEnergy(int myMoney, int cennik)
        {
            int myEnergies;
            myEnergies = myMoney / cennik;
            Console.WriteLine(" Ti mojesh kupit' " + myEnergies + " energeticov!=)");

            int sdacha;
            sdacha = myMoney % cennik;
            Console.WriteLine(" Y tebya ostalos' " + sdacha + " denyak!=(");
        }
        internal static void SwapNaeb(int chislo1, int chislo2)
        {


            Console.WriteLine("Chas lutii pricol bydet =)");
            int tmp = chislo1;
            chislo1 = chislo2;
            chislo2 = tmp;
            Console.WriteLine("Chislo 1  = " + chislo1);
            Console.WriteLine("Chislo 2  = " + chislo2);



        }
    }
}

