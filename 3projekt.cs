using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double a;
            if (double.TryParse(Console.ReadLine(),out a))
            {
                Console.WriteLine(a);
            }
            else 
            { 
                Console.WriteLine("Błędne dane");
            }*/

            /*double a;
            a = Double.Parse(Console.ReadLine());*/

            bool isCorrect = false;
            do
            {
                Console.Write("Podaj a:");
                double a;
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.Write("Wpisz przawidłowe dane:");
                }
                Console.Write("Podaj b:");
                double b;
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.Write("Wpisz przawidłowe dane:");
                }
                Console.Write("Podaj c:");
                double c;
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.Write("Wpisz przawidłowe dane:");
                }
                if (IsTriangle(a, b, c))
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    isCorrect = true;
                    Console.WriteLine("Pole trójkąta o bokach {0}, {1}, {2} wynosi: {3:F4}cm\u00B2", a, b, c, Heron(a, b, c));
                    Console.OutputEncoding = System.Text.Encoding.Default;
                }
                else
                {
                    Console.WriteLine("Podane boki nie tworzą trójkąta");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            } while (!isCorrect);


            
            Console.ReadKey();
        }
    static bool IsTriangle(double a,double b,double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    static double Heron(double a,double b,double c) 
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
