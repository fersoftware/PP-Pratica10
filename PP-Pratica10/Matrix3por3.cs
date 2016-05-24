using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Elabore um programa em C# que leia os valores de uma matriz 3x3 de inteiros. Crie um
 * vetor de 3 elementos, contendo o total de cada coluna e exiba os valores desse vetor
 */
namespace PP_Pratica10
{
    class Matrix3por3
    {
        public void Exibir()
        {
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
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
