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
            int[,] matriz = new int[c,l];

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}
