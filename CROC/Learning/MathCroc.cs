using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{
    public class MathCroc

    {
        public static double DollarToeEur = 0.94;
        public static double DollarToRub = 96.04;
        public static double DollarToKzt = 474.0;
        public static double EurToRub = 101.94;
        public static double EurToKzt = 501.94;
        public static double KztToRub = 0.2;
        public enum Value
        {
            USD,
            EUR,
            RUB,
            KZT
        }
        public static void SrdneeArif(double a, double b)
        {

            double resault = (a + b) / 2;
            Console.WriteLine($"SREDNEE ARIFMETICHESKOE RAVNO {resault}");

        }
        public static void SummaAndProizved(int a, int b, int c)
        {
            int summa = a + b + c;
            int proizv = a * b * c;
            Console.WriteLine($"Summa 3 chisel ravna {summa}, a proizvedenie {proizv}");

        }
        public static void Converter(double couterOfBabki, Value valuta1, Value valuta2)

        {
            if (valuta1 == Value.USD)
            {
                double coff = 1;
                switch (valuta2)
                {
                    case Value.EUR:
                        coff = DollarToeEur;
                        break;
                    case Value.KZT:
                        coff = DollarToKzt;
                        break;
                    case Value.RUB:
                        coff = DollarToRub;
                        break;
                }
                double result = couterOfBabki * coff;
                Console.WriteLine(result);
            }
            else if (valuta1 == Value.EUR)
            {
                double coff = 1;
                switch (valuta2)
                {
                    case Value.USD:
                        coff = 1 / DollarToeEur;
                        break;
                    case Value.KZT:
                        coff = EurToKzt;
                        break;
                    case Value.RUB:
                        coff = EurToRub;
                        break;
                }
                double result = couterOfBabki * coff;
                Console.WriteLine(result);
            }
            else if (valuta1 == Value.KZT)
            {
                double coff = 1;
                switch (valuta2)
                {
                    case Value.EUR:
                        coff = 1 / EurToKzt;
                        break;
                    case Value.USD:
                        coff = 1 / DollarToKzt;
                        break;
                    case Value.RUB:
                        coff = KztToRub;
                        break;
                }
                double result = couterOfBabki * coff;
                Console.WriteLine(result);
            }
            else if (valuta1 == Value.RUB)
            {
                double coff = 1;
                switch (valuta2)
                {
                    case Value.EUR:
                        coff = 1 / EurToRub;
                        break;
                    case Value.KZT:
                        coff = 1 / KztToRub;
                        break;
                    case Value.USD:
                        coff = 1 / DollarToRub;
                        break;
                }
                double result = couterOfBabki * coff;
                Console.WriteLine(result);
            }


        }
        //        public static void CalcAB(int A, int B)
        //        {
        //            if (A - B == 0)
        //            {
        //                Console.WriteLine("Ti che ebanylsya na 0 delit'? )=");
        //                return;
        //            }

        //            int D = (A * 5 + B * B) / (A - B);



        //            Console.WriteLine(" Rezultatik raven " + D + " =)!");

        //        }
        //        public static void CalcX(int A, int B, int C)

        //        {
        //            if (A == 0 || B == 0 || C == 0)
        //            {
        //                Console.WriteLine(" Hyeta");
        //                return;
        //            }

        //            int X = (C - B) / A;

        //            Console.WriteLine(" X raven " + X + " =)!");
        //        }
        //        public static void CalcPryamaya(int x1, int x2, int y1, int y2)
        //        {
        //            int k = (y1 - y2) / (x1 - x2);
        //            int b = y2 - k * x2;

        //            if (x1 - x2 == 0)
        //            {
        //                Console.WriteLine("Poka");
        //                return;

        //            }
        //            // y = k * x + b

        //            Console.WriteLine("ETO TYPOE GOVNO = " +  y1 + "=" + k + "*" + x1 + "+" + b + "!!!!!!!!!!!!!!!!!!!!!!!!!!!11111111111111111111111111111111");


        //        }

        //        public static void RemoveFirstLastCharacter()




    }
}

