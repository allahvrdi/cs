using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3_matris
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matris =
            {
                {1,5,7},
                {3,12,8},
                {36,23,42}
            };
            for(int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
