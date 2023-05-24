using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex05
    {
        //função para o algoritmo de euclides
        public static int MDC(int a, int b, int r, int madc)
        {
            //se a maior que b
            if (a > b)
            {
                r = a - b;
                a = r;

                //estrutura de repetição
                while (r != 0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                    madc = a;
                }
            //se b maior que a
            } else if (b > a)
            {
                r = b - a;
                b = r;

                //estrutura de repetição
                while (r != 0)
                {
                    r = b % a;
                    b = a;
                    a = r;
                    madc = b;
                }
            } else
            {
                madc = a;
            }

            //retorna variavel maior divisor comum (madc)
            return madc;
        } 

        //procedimento MAIN
        public static void Executar()
        {
            //declarando variavel e atribuindo valor
            int x = 0, y = 0, z = 0, c = 0;

            //alterando valor de x
            Console.WriteLine("Insira o valor de um número inteiro x: ");
            x = int.Parse(Console.ReadLine());

            //alterando valor de y
            Console.WriteLine("Insira o valor de um número inteiro y: ");
            y = int.Parse(Console.ReadLine());

            
            //imprimindo na tela e chamando função MDC
            Console.WriteLine("O MDC de {0} e {1} é {2}", x, y, MDC(x, y, z, c));

            
            
        }
    }


}
