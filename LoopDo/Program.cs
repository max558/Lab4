using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDo
{
    /*
     * Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
     * Последовательность потенциально не ограничена, окончанием последовательности служит число 0
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numder,
                numPositive = 0,
                numNegative = 0;
            Console.WriteLine("Введите последовательность чисел (для завершения введите 0): ");
            do
            {
                Console.Write("Введите число в последовательность: ");
                numder = Convert.ToInt32(Console.ReadLine());
                if (numder > 0)
                {
                    numPositive++;
                }
                if (numder < 0)
                {
                    numNegative++;
                }

            } while (numder != 0);
            string numStr="";

            if (numPositive> numNegative)
            {
                numStr = "больше";
            }
            else
            {
                numStr = "меньше";
            }

            Console.WriteLine("Количество положительных чисел {0}, {1}, чем количество отрицательных чисел {2}", numPositive, numStr, numNegative);
            Console.ReadKey();
        }
    }
}
