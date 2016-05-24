using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elabore um método ExibeMatriz, que recebe uma matriz de inteiros e exibe seus valores
 * em forma de matriz. Escreva no Main o código que leia os valores de duas matrizes 2x3
 * de inteiros. Depois calcule a soma dessas duas matrizes, armazenando a soma em uma
 * terceira matriz e exiba os valores dessa terceira matriz (chame o método ExibeMatriz * para exibir a matriz).
 */
namespace PP_Pratica10
{
    class MatrixSomaMatrix
    {
        public void Exibir()
        {
            ExibeMatriz();
        }

        public void ExibeMatriz()
        {
            int[,] matrix1 = new int[2, 3];
            int[,] matrix2 = new int[2, 3];
            int[,] somaMatrix = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    somaMatrix[i, j] = matrix1[i, j] + matrix2[i, j];                    
                }
            }

            for (int i = 0; i < somaMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < somaMatrix.GetLength(1); j++)
                {
                    Console.Write(somaMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
