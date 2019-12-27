using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with the quantity rows: ");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter with the quantity cols: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matriz = Matriz.EnterDataMatriz(row, col);

            Matriz.PrintMatriz(matriz, row, col);


            Console.WriteLine("Enter with number ");
            int number = int.Parse(Console.ReadLine());

            Matriz.IdentityNumber(number, matriz, row, col);

         
         
        }

    }
}
