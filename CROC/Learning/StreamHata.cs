
using System.Dynamic;

namespace CROC.Learning
{
    internal static class StreamHata
    {
        public static void SimpDoika()
        {
            Console.WriteLine("Ckol'ko denyak stoit zakazat' music?");
            Console.WriteLine("50 denyak");

            string rub = " rubasov";


            int baza = 0;
            int[] simpBox = new int[8];
            int simpCounter = 0;

            while (simpCounter < 8 && baza <= 100000)
            {
                int donatik = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(donatik + rub);

                simpBox[simpCounter] = donatik;
                simpCounter++;

                if (donatik > 10000)
                {
                    Console.WriteLine("NIHUYA SEBE");
                    Console.WriteLine("ti v dole 35%");
                }
                else if (donatik > 1000)
                    Console.WriteLine("normal, mb eshe 5 rub dokinesh?");
                else if (donatik > 100)
                    Console.WriteLine("segodnya akcia 1.5 po cene 1");
                else if (donatik >= 50)
                    Console.WriteLine("huinya vopros");
                else
                    Console.WriteLine("livni pls");
                baza += donatik;
                Console.WriteLine("Crocobalance " + baza);

            }
            RaschetSimpov(simpCounter, simpBox, rub);

        }
        public static void RaschetSimpov(int simpCounter, int[] simpBox, string rub)
        {
            simpCounter = 0;
            while (simpCounter < 8)
            {
                if (simpBox[simpCounter] == 0)
                    break;
                else
                {
                    Console.WriteLine("Simp № " + simpCounter + " zadonil " + simpBox[simpCounter] + rub);
                    simpCounter++;

                }


            }
        }
        public static void CrocoBalance()
        {
        }

    }
}
//Console.WriteLine("Ckol'ko denyak stoit zakazat' music?");
//Console.WriteLine("50 denyak");

//string rub = " rubasov";


//int baza = 0;
//int[] simpBox = new int[8];
//int simpCounter = 0;

//while (simpCounter < 8 && baza <= 100000)
//{
//    int donatik = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(donatik + rub);

//    simpBox[simpCounter] = donatik;
//    simpCounter++;

//    if (donatik > 10000)
//    {
//        Console.WriteLine("NIHUYA SEBE");
//        Console.WriteLine("ti v dole 35%");
//    }
//    else if (donatik > 1000)
//        Console.WriteLine("normal, mb eshe 5 rub dokinesh?");
//    else if (donatik > 100)
//        Console.WriteLine("segodnya akcia 1.5 po cene 1");
//    else if (donatik >= 50)
//        Console.WriteLine("huinya vopros");
//    else
//        Console.WriteLine("livni pls");
//    baza += donatik;
//    Console.WriteLine("Crocobalance " + baza);

//}
//simpCounter = 0;
//while (simpCounter < 8)
//{
//    if (simpBox[simpCounter] == 0)
//        break;
//    else
//    {
//        Console.WriteLine("Simp № " + simpCounter + " zadonil " + simpBox[simpCounter] + rub);
//        simpCounter++;

//    }


//}