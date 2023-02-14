using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Test
{
    class Money
    {
        private double rubles;

        public double Rubles
        {
            get { return rubles; }
            set { if (value >= 0 && value <= 1000) rubles = value; else WriteLine("Error"); }
        }

        private double kopecks;

        public double Kopecks
        {
            get { return kopecks; }
            set { if (value >= 0 || value <= 99) kopecks = value; else WriteLine("Error"); }
        }

        public Money()
        {
            rubles = 0;
            kopecks = 0;
        }
        //public Money(double rubles,  double kopecks)
        //{
        //    this.rubles = rubles;
        //    this.kopecks = kopecks;
        //}

        static public Money Setter(ref Money m)
        {
            WriteLine("Enter rubles");
            m.rubles = Convert.ToDouble(ReadLine());
            WriteLine("Enter kopecks");
            m.kopecks = Convert.ToDouble(ReadLine());
            Clear();
            return m;

        }
        static double Convert_money(ref Money m)
        {

            m.kopecks = (m.rubles * 100) + m.kopecks;
            return Math.Round(m.kopecks, 2);

        }

        static public double Summa(ref double s)
        {
            Money m1 = new Money();
            WriteLine("Set the first object\n");
            Setter(ref m1);
            Money m2 = new Money();
            WriteLine("Set the second object\n");
            Setter(ref m2);
            s = (m1.rubles + m1.kopecks / 100) + (m2.rubles + m2.kopecks / 100);
            WriteLine($"Total summ of two objects = {s} rubles");
            return s;
        }
        static public double Percent(ref double r)
        {
            WriteLine();
            Money m = new Money();
            WriteLine("Set the object\n");
            Setter(ref m);
            WriteLine("\nEnter percent you would like to count");
            int p;
            p = Convert.ToInt32(ReadLine());
            if (p > 0 && p < 100)
            {
                r = ((m.rubles + m.kopecks / 100) * p) / 100;
            }
            WriteLine($"The result is {r} rubles");
            return r;
        }

        public override string ToString()
        {

            return $"value = {rubles} rubles {kopecks} kopecks";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Money m1 = new Money();
            Money m2 = new Money();
            Money.Summa(ref n);
            Money.Percent(ref n);

        }
    }
}