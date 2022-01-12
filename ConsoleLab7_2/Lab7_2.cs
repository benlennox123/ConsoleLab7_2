using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab7_2
{
    class Lab7_2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба - ");
            double A = Convert.ToDouble(Console.ReadLine());
            S_V_cube(A);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }

        static void S_V_cube(double A)
        {
            double S = Math.Pow(A, 2) * 6;
            double V = Math.Pow(A, 3);
            Console.WriteLine("Площадь - {0} квадратных единиц", S);
            Console.WriteLine("Объём - {0} кубических единиц", V);
        }
    }
}
