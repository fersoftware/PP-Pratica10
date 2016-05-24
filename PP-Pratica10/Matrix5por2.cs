using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elabore um programa em C# que cria uma matriz 5x2 de strings. A primeira coluna
 * deverá armazenar nomes de amigos e a segunda coluna deverá armazenar os números de 
 * telefones correspondentes (no formato string). Solicite que o usuário digita os dados 
 * para preencher a matriz. Depois, solicite que o usuário digite um nome qualquer. 
 * pesquise o nome na matriz e exiba “Nome não encontrado”, caso o nome não esteja na 
 * matriz, ouexiba o telefone correspondente, caso o nome esteja na matriz.
 */

namespace PP_Pratica10
{
    class Matrix5por2
    {
        public void Exibir()
        {
            string[,] matrix = new string[5, 2];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Digite um nome: ");
                        matrix[i, j] = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Digite um telefone: ");
                        matrix[i, j] = Console.ReadLine();
                    }
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

            Console.Write("Digite o nome para pesquisa:");
            string p = Console.ReadLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == p)
                    {
                        Console.Write(matrix[i, j+1]);
                    }                    
                }                
            }
           
        }
    }
}
