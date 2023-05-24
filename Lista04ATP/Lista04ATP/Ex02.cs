using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex02
    {
        //procedimento
        static void MediaSalario(int habitantes, double salario, int nf)
        {
            //declarando variavel e atribuindo valor
            double media = salario/habitantes;
            Console.WriteLine("A média salarial da população é {0}", media);
        }

        //procedimento MAIN
        public static void Executar()
        {
            //declarando variaveis e atribuindo valores
            int numF = 0;//numero de filhos
            int hab = 0; //habitantes
            int sal = 0; //salario

            //estrutura de repetição
            do
            {
                //atribuindo valor a variavel numF
                Console.Write("\nInsira o número de filhos:");
                numF = int.Parse(Console.ReadLine());

                hab++; //adicionando numeor de habitantes em um

                //atribuindo valor a variavel sal
                Console.Write("\nInsira o salário (Para encerrar digite 0): ");
                sal = int.Parse(Console.ReadLine());
            } while (sal != 0);

            hab = hab + numF;

            //chamando procedimento
            MediaSalario(hab, sal, numF);
        }
    }
}
