using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.Learning
{
    public class Food
    {
        public string Name { get; set; }
        public int KKal { get; set; }
        public double Weight { get; set; }
        public bool GlutenFree { get; set; }
        public double Cost { get; set; }
        public bool RazrivPizdi { get; set; }

        public double Belki { get; set; }
        public double Jiri { get; set; }
        public double Ugli { get; set; }

        public Food(string name, int kKal, double weight, bool glutenFree, double cost, bool razrivPizdi, double belki, double jiri, double ugli)
        {
            Name = name;
            KKal = kKal;
            Weight = weight;
            GlutenFree = glutenFree;
            Cost = cost;
            RazrivPizdi = razrivPizdi;
            Belki = belki;
            Jiri = jiri;
            Ugli = ugli;
        }
        public double CalcKkal(int counter)

        {

            double result = KKal * Weight / 100 * counter;

            return result;

        }
        public double CalcCost(int counter)

        {

            double result = Cost * counter;

            return result;
        }

        public double CalcNormaKKal(int normakkal, int counter)

        {
            double kkkkal = KKal * (Weight / 100) * counter;
            double kkkal2 = kkkkal / normakkal;
            double result = kkkal2 * 100;
            return result;
        }

    }
}
