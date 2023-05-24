using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex03
    {
        //procedimento para definir os numeros em ordem crescente
        public static void Crescente(int a, int b, int c)
        {
            //vetor de int numeros
            int[] numeros = { a, b, c };

            //comando para organizar numeros em forma crescente
            Array.Sort(numeros);
            Console.WriteLine(string.Join(" ", numeros));
        }

        //procedimento MAIN
        public static void Executar()
        {
            //declarando e atribuindo valor a variavel
            int n; //numeros
            Console.WriteLine("Digite a quantidade de conjuntos: ");
            n = int.Parse(Console.ReadLine());

            //estrutura de repetição
            for (int i = 0; i < n; i++)
            {
                //declarando e atribuindo valor a variavel
                int a;
                Console.WriteLine("Digite o valor um do conjunto: ");
                a = int.Parse(Console.ReadLine());

                //declarando e atribuindo valor a variavel
                int b;
                Console.WriteLine("Digite o valor um do conjunto: ");
                b = int.Parse(Console.ReadLine());

                //declarando e atribuindo valor a variavel
                int c;
                Console.WriteLine("Digite o valor um do conjunto: ");
                c = int.Parse(Console.ReadLine());

                Console.Write("Os valores do conjunto {0} em ordem crescente são: ", (i+1));
                
                //chamando o procedimento
                Crescente(a, b, c);
            }
        }

    }
}
