using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar o método ExibeNum10a20, que recebe uma matriz de inteiros e exibe a
 * quantidade de elementos existentes em cada linha, entre 10 e 20.
 * Elaborar o método MediaPares, que recebe uma matriz de inteiros e devolve a média dos
 * elementos pares existentes na matriz.
 * Elaborar o método Main que solicita que o usuário digite o número de linhas e o número
 * de colunas da matriz. Depois, solicita que o usuário digite os valores dos elementos
 * dessa matriz. Chame o método ExibeNum10a20 e o método MediaPares. Exiba a média
 * dos elementos pares da matriz.
 */

namespace PP_Pratica10
{
    class Matriz10a20
    {
        public void Exibir()
        {
            Console.Write("Digite o Número de Colunas: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Digite o Número de Linhas: ");
            int l = int.Parse(Console.ReadLine());

            int[,] matriz = new int[l,c];

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Digite um número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            MontaMatriz(matriz);
            Console.WriteLine();

            ExibeNum10a20(matriz);
            MediaPares(matriz);
        }

        public void MontaMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void MediaPares(int [,] matriz)
        {
            string pares = "";
            int soma = 0, cont = 0;

            foreach (var item in matriz)
            {
                if(item%2 == 0)
                {
                    pares += item + " ";
                    soma += item;
                    cont++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Os pares são: {0}", pares);
            Console.WriteLine("Média dos valores pares são: {0}", soma / cont);
        }

        public void ExibeNum10a20(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int cont = 0;
                Console.Write("Na linha {0} ",i);
                for (int j = 0; j < matriz.GetLength(1); j++)
                {   
                    if(matriz[i, j] >= 10 && matriz[i, j] <= 20)
                    {
                        Console.Write(matriz[i, j] + " ");
                        cont++;
                    }
                }
                Console.Write(" ou seja {0} valor(es) no total ", cont);
                Console.WriteLine();
            }
        }
    }
}
