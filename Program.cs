using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 12. Совершенными называют числа, равные сумме всех своих 
    делителей (естественно, кроме самого числа). Например, 
    совершенным является число 6 (6 = 1 + 2 + 3). 
    Найти трехзначное совершенное число. */

namespace Lab_3_2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 999; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)                    
                        sum += j;                    
                }
                if (sum == i)                
                    Console.WriteLine(i);                
            }
            Console.ReadKey();
        }
    }
}
