using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Escreva um programa em C# que leia os valores de uma matriz 2x3 de inteiros e depois * exiba os valores em forma de matriz. 
 */
namespace PP_Pratica10
{
    class LerValorMatrix
    {
        public void Exibir()
        {
            int[,] matrix = new int[2,3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
