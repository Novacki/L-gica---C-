using System;
using System.Collections.Generic;
using System.Text;

namespace Matriz
{
    class Matriz
    {
        public static int[,] EnterDataMatriz(int row, int col)
        {
            int[,] matriz = new int[row, col];
            for(int i = 0; i < row; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "° Linha: ");
                string[] values = Console.ReadLine().Split(" ");

                for(int j = 0; j < col; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);   
                }
            }

            return matriz;
        }
        public static void PrintMatriz(int[,] matriz, int row, int col)
        {
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public static void IdentityNumber(int number, int[,] matriz, int row, int col)
        {
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if(number == matriz[i, j])
                    {
                        Console.WriteLine("Row: " + (i + 1) + " Col: " + (j + 1) + ": " + number);

                        if(j != 0)
                            Console.WriteLine("Left: " + matriz[i,(j - 1)]);
                        if(j != (col - 1))
                            Console.WriteLine("Right: " + matriz[i, (j + 1)]);
                        if(i != 0)
                            Console.WriteLine("Top: " + matriz[(i - 1), j]);
                        if(i != (row - 1))
                            Console.WriteLine("Botton: " + matriz[(i + 1), j]);
                    }
                }
            }
        }
    }
}
