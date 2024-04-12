using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_TEST_12_04_24
{
    public class Program
    {
        public static string Ur(double a, double b, double c) {
            
            double x1, x2;

            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                return("Квадратное уравнение не имеет корней");

            }
            else
            {
                if (discriminant == 0) 
                {
                    x2 = x1 = (-b) / (2 * a);
                }
                else 
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                
                return($"x1 = {x1}; x2 = {x2}");
            }

        }



        static void Main(string[] args)
        {

            Console.WriteLine("Решение квадратного уравнения");
            //ввод данных
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());

            Ur(a,b,c);
            

            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
