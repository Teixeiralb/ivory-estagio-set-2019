using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_2_Matriz
{
    class Program
    {
        static string[,] matriz;
        static int larguraMatriz;
        const int quantidadeLinhasMatriz = 3;

        static void Main(string[] args)
        {
            string resposta = "S";

            while (resposta == "S")
            {
                string nome = LerNome();
                CriarMatriz(nome);
                ImprimirMatriz();

                Console.WriteLine("Deseja digitar outro nome? S ou N");
                resposta = Console.ReadLine().ToUpper();
            }
        }
        
        private static void CriarMatriz(string nome)
        {
            int valorNumerico = 1;
            larguraMatriz = nome.Length + 2;

            matriz = new string[quantidadeLinhasMatriz, larguraMatriz];

            for (int linha = 0; linha < quantidadeLinhasMatriz; linha++)
            {
                if (linha ==Convert.ToInt16( linhaEnum.Cabecalho))
                {
                    for (int coluna = 0; coluna < larguraMatriz; coluna++)
                    {
                        matriz[linha, coluna] = valorNumerico.ToString();
                        valorNumerico++;
                    }

                }
                else if (linha == Convert.ToInt16(linhaEnum.Conteudo ))
                {
                    int indiceLetra = 1;

                    matriz[linha, larguraMatriz - 1] = valorNumerico.ToString();
                    matriz[linha, 0] = (valorNumerico * 2).ToString();
                    valorNumerico++;

                    foreach (var letra in nome)
                    {
                        matriz[linha, indiceLetra] = letra.ToString();
                        indiceLetra++;
                    }

                }
                else if (linha == Convert.ToInt16(linhaEnum.Rodape))
                {
                    for (int coluna = larguraMatriz - 1; coluna >= 0; coluna--)
                    {
                        matriz[linha, coluna] = valorNumerico.ToString();
                        valorNumerico++;
                    }
                }
            }
        }

        private static void ImprimirMatriz()
        {
            for (int linha = 0; linha < quantidadeLinhasMatriz; linha++)
            {
                for (int coluna = 0; coluna < larguraMatriz; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "|");
                }

                Console.WriteLine();
            }
        }

        static string LerNome()
        {
            
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            return nome;
        }

        public enum linhaEnum
        {
            Cabecalho = 0,
            Conteudo = 1,
            Rodape = 2
        }
        
    }
}
