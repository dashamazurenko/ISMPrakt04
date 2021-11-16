using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPrakt04
{
    public class Class1
    {
        
        public static int DobFromAtoB(int a, int b)
        { 
            int result = 1;
            if (a > b)
            {
                Console.Write("Error");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    result *= i;

                }
            }
            return (result);
        }
        public static float Suma(int a)
        {
            
            float result = 0.0F;
            for (int i = 1; i <= a; i++)
            {
                result += 1.0F / i;
            }
            return (result);
        }
        public static double Stepin(double a, int b)
        {
            
            double result = 1;
            for (double i = a; i < b; i++)
            {
                result = Math.Pow(a, b);
            }
            return (result);
        }
        public static double SumaKv(double a, double b)
        {
            
            double result = 0.0F;
            for (double i = a; i <= b; i++)
            {
                result += Math.Pow(i, 2);
            }
            return (result);
        }
        public static double Factorial(double a)
        {
            
            double Fact = 1;
            if (a == 0)
                Console.Write("Error");
            for (int i = 1; i <= a; i++)
            {
                Fact *= i;
            }
            return (Fact);
        }
        public static double SumaWhile1(double a)
        {
           
            double result = 0;
            int i = 1;
            while (i <= a)
            {
                result += Math.Pow(i, a - i + 1);
                i++;
            }
            return (result);
        }
        public static double MinCile(int k, double a)
        {
            
            int result = 0;
            while (Math.Pow(3, k) < a)
            {
                result = k++;
            }
            return (result);
        }
        public static double SumaDniv(out double summa, out double k, double p)
        {
            
            summa = 10;
            k = 1;
            double result = 0;
            double d = 10;
            while (summa <= 200)
            {
                ++k;
                d += d * p / 100;
                summa += d;
                result = summa;
            }
            return result;
        }
        public static double SumaDoWhile(int summa, string[] arr)
        {
            
            int i = 0;
            summa = 0;
            int result;
            do
            {
                summa += int.Parse(arr[i]);
                result = summa;
                 i++;
            } while (arr.Length > i);
            return (result);
        }
    }
}
