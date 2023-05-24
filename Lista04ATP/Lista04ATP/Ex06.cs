using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex06
    {
        //função para definir se variavel é positivo ou negativo
        public static bool PositivoNegativo(int a)
        {
            //se a maior que zero
            if (a > 0)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        //procedimento main
        public static void Executar()
        {
            //declarando variavel
            int u, r;

            //atribuindo valor a variavel r
            Console.WriteLine("Insira a quantidade de números serão lidos: ");
            r = int.Parse(Console.ReadLine());

            //estrutura de repetição
            for (int i = 0; i < r; i++)
            {
                //atribuindo valor de u
                Console.WriteLine("Insira um valor positivo ou negativo: ");
                u = int.Parse(Console.ReadLine());
                               
                if (PositivoNegativo(u) == true)
                {
                    Console.WriteLine("O número {0} é positivo", u);
                }
                else if (PositivoNegativo(u) == false)
                {
                    Console.WriteLine("O número {0} é negativo", u);
                } 
            }
        }
    }
}
