using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elabore um programa em C# que leia os valores de dois vetores de 4 elementos inteiros
 * cada uma. Crie uma matriz 4x2, sendo que a primeira coluna dessa matriz deve
 * corresponder ao primeiro vetor e a segunda coluna dessa matriz deve corresponder ao
 * segundo vetor. Exiba a matriz. 
 */

namespace PP_Pratica10
{
    class Matrix4por2
    {
        public void Exibir()
        {
            int[] array1 = new int[4];
            int[] array2 = new int[4];
            int[,] matriz = new int[2, 4];
            int i = 0;

            for (i = 0; i < array1.Length; i++)
            {
                Console.Write("Digite um número: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (i = 0; i < array2.Length; i++)
            {
                Console.Write("Digite um número: ");
                array2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            i = 0;
            foreach (var item in array1)
            { matriz[0, i++] = item; }

            i = 0;
            foreach (var item in array2)
            { matriz[1, i++] = item; }
                        
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
