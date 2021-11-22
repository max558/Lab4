using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor
{
    /*
     * Ввести целое число N > 0. 
     * Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). 
     * После добавления к сумме каждого слагаемого выводить текущее значение суммы 
     * (в результате будут выведены квадраты всех целых чисел от 1 до N).
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numder;
            #region Входные данные
            Console.WriteLine("Введите целое число: ");
            numder = Convert.ToInt32(Console.ReadLine());
            #endregion

            int sum = 0;
            Console.WriteLine("");
            for (int i = 0; i < 2 * numder; i++)
            {

                if ((i % 2) != 0)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);                    
                }
            }
            Console.ReadKey();
        }
    }
}
