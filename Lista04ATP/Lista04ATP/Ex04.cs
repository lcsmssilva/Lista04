using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex04
    {
        //procedimento que define o modelo do triângulo
        public static void ComprimentoTri(int x, int y, int z)
        {

            /* se x é menor que y mais z
             * se y é menor que x mais z
             *se z é menor que y mais x */
            if (x < y + z && y < x + z &&  z < y + x)
            {
                //se x é igual a y e igual a z
                if (x == y && x == z)
                {
                    Console.WriteLine("É um triângulo Equilátero.\n");
                } 
                //se x é igual a y e diferente de z
                else if(x == y && x != z) 
                {
                    Console.WriteLine("É um triângulo Isósceles.\n");
                }
                //se z é igual a y e diferente de x
                else if (z == y && z != x)
                {
                    Console.WriteLine("É um triângulo Isósceles.\n");
                }
                //se x é diferente de y, diferente de z e y diferente de z
                else if (x != y && x != z && y != z) 
                {
                    Console.WriteLine("É um triângulo Escaleno.\n");
                }
            } 
            else
            {
                Console.WriteLine("Não pode ser comprimento de um triângulo.");
            }
        }

        //procedimento MAIN
        public static void Executar()
        {
            //declarando e atribuindo valor as variaveis
            int a = 0, b = 0, c = 0, p;

            //estrutura de repetição
            do
            {
                //atribuindo valor a variavel p
                Console.WriteLine("Para parar digite '0'.");
                p = int.Parse(Console.ReadLine());

                //alterando valor da variavel a
                Console.WriteLine("Insira o valor de a: ");
                a = int.Parse(Console.ReadLine());

                //alterando valor da variavel b
                Console.WriteLine("Insira o valor de b: ");
                b = int.Parse(Console.ReadLine());

                //alterando valor da variavel c
                Console.WriteLine("Insira o valor de c: ");
                c = int.Parse(Console.ReadLine());

                //chamando procedimento
                ComprimentoTri(a, b, c);

            } while (p != 0); //executar repetição enquanto p for diferente de 0
        }
    }
}
