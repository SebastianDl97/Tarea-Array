using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 1 }, { 1, 1 }, { 1, 1 } };
            int[,] B = { { 2, 2 }, { 2, 2 }, { 2, 2 } };
            int[,] resultado = new int[3, 3];
            int c;
            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                c = 0;
                while (c < 3)
                {

                    for (int j = 0; j < 2; j++)

                        suma = (suma) + ((A[i, j]) * (B[j, c]));
                    resultado[i, c] = suma;
                    c = c + 1;

                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.WriteLine(resultado[i, j] + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
