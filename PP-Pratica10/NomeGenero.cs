using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que solicita que o usuário digite o número N de nomes de
 * pessoas que irá fornecer. O programa deverá criar 2 vetores de tamanho igual ao número
 * digitado N. Em seguida, o programa deverá solicitar que o usuário digite os nomes e os
 * sexos de N pessoas. O programa deverá colocar os nomes das mulheres em um vetor e
 * os nomes dos homens no outro vetor. No final, o programa deverá informar a quantidade
 * de mulheres e os nomes de todas as mulheres e depois a quantidade de homens e os
 * nomes de todos os homens.
 * 
 */


namespace PP_Pratica10
{
    class NomeGenero
    {
        public void Exibir()
        {
            nomeGenero();
        }

        public void nomeGenero()
        {
            int n = 0;

            Console.Write("Digite a quantidade de pessoas: ");
            n = int.Parse(Console.ReadLine());

            string[] v1 = new string[n];
            string[] v2 = new string[n];
            char sexo = 'm';
            string nome = "";

            int cm = 0;
            int cf = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                Console.Write("Digite o sexo: m ou f: ");
                sexo = char.Parse(Console.ReadLine());

                if( sexo == 'm')
                {
                    v1[cm++] = nome;                    
                }
                else
                {
                    v2[cf++] = nome;
                }
            }

            Console.WriteLine("São {0} Mulheres e {1} Homen(s)", cf, cm);

            for (int i = 0; i < cm; i++)
            {
                Console.WriteLine("{0} - Homem", v1[i]);
            }

            for (int i = 0; i < cf; i++)
            {
                Console.WriteLine("{0} - Mulher", v2[i]);
            }

            
        }
    }
}
