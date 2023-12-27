using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{
    public class Zada4ki
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int sum = ClassPoints.Sum();
            int average = sum / ClassPoints.Length;
            return YourPoints > average;
        }

        public static string FakeBin(string x)
        {
            string newx = string.Empty;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < '5')
                {
                    newx += '0';
                }
                else
                {
                    newx += '1';
                }
            }

            return newx;
        }
        public static string Maskify(string cc)
        {
            char[] cc1 = cc.ToCharArray();
            for (int i = 0; i < cc.Length - 4; i++)
            {
                cc1[i] = '#';
            }
            string result = new string(cc1);
            return result;
        }
        public static int Multiply(int x)
        {

            if (x % 2 == 1)
            {
                int result9 = x * 9;
                return result9;
            }
            else
            {
                int result8 = x * 8;
                return result8;
            }


        }

    }
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * -1;
            }
            return input;
        }
    }
    public class Kata
    {
        public static int StringToNumber(string str)
        {
            int result = int.Parse(str);
            return result;
        }

        public static int Paperwork(int n, int m)
        {
            int result = 0;
            if (n > 0 && m > 0)
            {
                return result = n * m;
            }

            else if (n < 0 || m < 0)
            {
                return result = 0;
            }
            return result;

        }
        public static string RemoveExclamationMarks(string s)
        {
            foreach (char c in s)
            {
                if (c == '!')
                {
                    s = s.Replace(@"!", "");
                }
            }
            return s;
        }
        public static string AreYouPlayingBanjo(string name)
        {
            char[] chars = name.ToCharArray();
            if (chars[0] == 'R' || chars[0] == 'r')
            {
                return name + " plays banjo";
            }
            else
            {
                return name + " does not play banjo";
            }
        }
        public static int PositiveSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;

        }
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);
            if (bmi <= 18.5)
            {
                return "Underweight";

            }
            else if (bmi <= 25.0)
            {
                return "Normal";
            }
            else if (bmi <= 30.0)
            {
                return "Overweight";
            }
            else if (bmi > 30)
            {
                return "Obese";
            }
            return "";

        }
        public static int Grow(int[] x)
        {
            int grow = 1;
            for (int i = 0; i < x.Length; i++)
            {
                grow *= x[i];
            }
            return grow;
        }
        public static string DnaToRna(string dna)
        {
            string rna = dna;
            rna = rna.Replace('T', 'U');
            return rna;
        }
        public static string FindNeedle(object[] haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == "needle")
                {
                    return "found the needle at position " + i;
                }

            }
            return "";
        }
        public static string UpdateLight(string current)
        {
            switch (current)
            {
                case "green":
                    return "yellow";
                case "yellow":
                    return "red";
                case "red":
                    return "green";
                default:
                    return string.Empty;

            }

        }
        public static int DescendingOrder(int num)
        {
            string numStr = num.ToString();
            List<int> nums = new List<int>(numStr.Length);

            foreach (char c in numStr)
            {
                int intc = int.Parse(c.ToString());
                nums.Add(intc);
            }

            nums = nums.OrderByDescending(x => x).ToList();
            string res = string.Empty;
            foreach (int i in nums)
            {
                res += i.ToString();
            }
            int result = int.Parse(res);              

            return result;
        }



        //public void StillLife()
        //{
        //    string a1 = "буби";
        //    string a2 = "черви";
        //    string a3 = "буби";
        //    string a4 = "пики";
        //    string a5 = "трефы";

        //    while (a1 == "" &&)
        //    {

        //    }


        //}
        public static string ToRight(string a)
        {
            if (a == "черви")
            {
                a = "трефы";
                return a;
            }
            else if (a == "трефы")
            {
                a = "буби";
                return a;
            }
            else if (a == "буби")
            {
                a = "пики";
                return a;
            }
            else if (a == "пики")
            {
                a = "черви";
                return a;
            }
            return "";


        }
        public static string ToLeft(string a)
        {
            if (a == "черви")
            {
                a = "пики";
                return a;
            }
            else if (a == "пики")
            {
                a = "буби";
                return a;
            }
            else if (a == "буби")
            {
                a = "трефы";
                return a;
            }
            else if (a == "трефы")
            {
                a = "черви";
                return a;
            }
            return "";
        }
        public static string Likes(string[] name)
        {

            if (name.Length == 0)
            {
                return "no one like this";
            }
            else if (name.Length == 1)
            {
                return $"{name[0]} likes this";
            }
            else if (name.Length == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else if (name.Length >= 4)
            {
                int others = name.Length - 2;

                return $"{name[0]}, {name[1]} and {others} like this";
            }
            return "";

        }

        public static bool IsIsogram(string str)
        {
            string newstr = "";

            foreach (char c in str.ToLower())
            {
                if (newstr.Contains(c) == true)
                {
                    return false;
                }

                newstr += c;
            }
            return true;

        }
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            List<int> listnumbers = numbers.ToList();
            listnumbers.Sort();
            int sum = listnumbers[0] + listnumbers[1];
            return sum;

        }
        public static string PigIt(string str)
        {
            string[] words = str.Split(' ');

            List<string> strlist = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string tmp = words[i];
                bool OnlyLetters = tmp.Any(c => !char.IsPunctuation(c));
                if (OnlyLetters)
                {
                    char first = tmp[0];
                    tmp = tmp.Remove(0, 1);
                    tmp += first;
                    tmp += "ay";
                    strlist.Add(tmp);
                }
                else
                {
                    strlist.Add(tmp);
                }
            }
            string result = string.Join(" ", strlist);
            return result;
        }
    }

}





//public class RpsGamer
//{
//    public string Name { get; set; }


//    public RpsGamer(string name)
//    {
//        Name = name;
//    }
//    public enum Rps
//    {
//        камень = 1,
//        бумага = 2,
//        ножницы = 3,
//    }
//    public static void HelloRps()
//    {
//        Console.WriteLine($"Я сделала игру, в которой 2 рандомных гандона (которым, кстати, можно дать имя)\n" +
//            $"хуярятся в камень-ножницы-бумага на рандомычах, просто показываю =Р");
//    }
//    public static void Fight(RpsGamer Player1, RpsGamer Player2)
//    {
//        Array values = Enum.GetValues(typeof(Rps));
//        Random random = new Random();

//        int win1 = 0;
//        int win2 = 0;

//        while (win1 < 3 && win2 < 3)
//        {

//            Rps randomRps1 = (Rps)values.GetValue(random.Next(values.Length));

//            Console.WriteLine($"{Player1.Name} выбирает {randomRps1}");

//            Rps randomRps2 = (Rps)values.GetValue(random.Next(values.Length));

//            Console.WriteLine($"{Player2.Name} выбирает {randomRps2}");

//            if (randomRps1 == randomRps2)
//            {
//                Console.WriteLine($"{Player1.Name} и {Player2.Name} выбрали {randomRps1} и партия завершилась ничьей");
//            }
//            else if (randomRps1 == Rps.камень)
//            {
//                switch (randomRps2)
//                {
//                    case Rps.бумага:
//                        win2++;
//                        break;
//                    case Rps.ножницы:
//                        win1++;
//                        break;
//                }
//            }
//            else if (randomRps1 == Rps.бумага)
//            {
//                switch (randomRps2)
//                {
//                    case Rps.камень:
//                        win1++;
//                        break;
//                    case Rps.ножницы:
//                        win2++;
//                        break;
//                }
//            }
//            else if (randomRps1 == Rps.ножницы)
//            {
//                switch (randomRps2)
//                {
//                    case Rps.бумага:
//                        win1++;
//                        break;
//                    case Rps.камень:
//                        win2++;
//                        break;
//                }
//            }

//        }

//        if (win1 == 3)
//        {
//            Console.WriteLine($"{Player1.Name} одержал победу со счетом {win1}/{win2}!");
//        }
//        else if (win2 == 3)
//        {
//            Console.WriteLine($"{Player2.Name} одержал победу со счетом {win2}/{win1}!");
//        }

//    }


//}
