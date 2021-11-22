using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    /*
     * Ввести положительные числа A, B, C. 
     * На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
     * Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double numA = 0,
                numB = 0,
                numC = 0;
            #region Входные данные
            Console.WriteLine("Введите положительное число ");
            Console.Write("A: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.Write("C: ");
            numC = Convert.ToDouble(Console.ReadLine());
            #endregion

            int a = 0,
                b = 0;
            double resAC = 0,
                resBC = 0;
            //Определяем кол-во квадратов по стороне А
            while (resAC <= numA)
            {
                resAC = resAC + numC;
                if (resAC > numA)
                {
                    break;
                }
                a++;
            }
            //Определяем кол-во квадратов по стороне B
            while (resBC <= numB)
            {
                resBC = resBC + numC;
                if (resBC > numB)
                {
                    break;
                }
                b++;
            }
            //Определяем общее кол-во квадратов
            int cvadro = 0;
            while (a > 0)
            {
                int ji = b;
                while (ji > 0)
                {
                    cvadro++;
                    ji--;
                }
                a--;
            }
            Console.WriteLine(cvadro);
            Console.ReadKey();
        }
    }
}
