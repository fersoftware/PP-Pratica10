using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar o método IndiceMenorValor, que recebe um vetor de inteiros e devolve o índice
 * do menor valor contido no vetor.
 * A assinatura do método deve ser:
 * static int IndiceMenorValor ( int[ ] v)
 * Elaborar o método Main que inicializa um vetor chamado vet com 15 números inteiros, a
 * sua escolha, sem ler os valores. Depois, o Main deve chamar o método IndiceMenorValor,
 * passando o vetor vet para obter o índice do menor valor. Quando se chama o método
 * passando um vetor, basta colocar o nome do vetor dentro do parênteses:
 * IndiceMenorValor(vet)
 * Atenção: Essa chamada retorna um valor, e portanto você deve atribuir o valor para uma
 * variável:
 * int indMenor = IndiceMenorValor(vet);
 * ou efetuar a chamada dentro de um Console.WriteLine:
 * Console.WriteLine(“Índice de menor valor é “ + IndiceMenorValor(vet));
 * O Main deve exibir esse índice e também o menor valor do vetor. No final, o Main deve
 * rocar o menor valor do vetor com o valor da primeira posição do vetor e exibir o vetor
 * após essa troca.
 */
namespace PP_Pratica10
{
    class MenorValor
    {
        public void Exibir()
        {
            int[] vet = new int[15];
            int menor = 0, maior = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    menor = vet[0];
                    maior = vet[0];
                }

                if (vet[i] < menor)
                { menor = vet[i]; }
                else if (vet[i] > maior)
                { maior = vet[i]; }
            }

            Console.WriteLine("O menor valor é " + menor);
            Console.WriteLine("Índice de menor valor é " + IndiceMenorValor(vet));

        }
        static int IndiceMenorValor(int[] v)
        {
            int menor = 0, maior = 0, posicao_menor = 0, posicao_maior = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (i == 0)
                {
                    menor = v[0];
                    maior = v[0];
                }

                if (v[i] < menor)
                {
                    menor = v[i];
                    posicao_menor = i;
                }
                else if (v[i] > maior)
                {
                    maior = v[i];
                    posicao_maior = i;
                }
            }
            //Console.WriteLine("O menor número é:" + menor);
            //Console.WriteLine("A posição do menor número é:" + posicao_menor);
            //Console.WriteLine("O maior número é:" + maior);
            //Console.WriteLine("A posição do maior número é:" + posicao_maior);
            return posicao_menor;
        }
    }
}
