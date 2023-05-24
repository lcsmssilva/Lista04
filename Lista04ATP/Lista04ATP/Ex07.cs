using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex07
    {
        //static void pois é um procedimento
        public static void Notas(int a)
        {
            //Utilizando IF para atribuir o conceito da nota com a variavel 'a'
            if (a <= 39)
            {
                Console.WriteLine("O conceito do aluno é: F\n");
            }
            else if (a > 39 && a < 60)
            {
                Console.WriteLine("O conceito do aluno é: E\n");
            }
            else if (a > 59 && a < 70)
            {
                Console.WriteLine("O conceito do aluno é: D\n");
            }
            else if (a> 69 && a < 80)
            {
                Console.WriteLine("O conceito do aluno é: C\n");
            }
            else if (a > 79 && a < 90)
            {
                Console.WriteLine("O conceito do aluno é: B\n");
            }
            else if ( a > 89)
            {
                Console.WriteLine("O conceito do aluno é: A\n");
            }
        }
        public static void Executar()
        {
            //declarando variavel, atribuindo valor e convertendo a variavel de string para int
            int alunos; 
            Console.WriteLine("Insira a quantidade de alunos: ");
            alunos = int.Parse(Console.ReadLine());

            //utilizando metodo de repetição for pois temos a quantidade exata de alunos
            for(int i = 0; i < alunos; i++)
            {
                int n;
                Console.WriteLine("Insira a nota do aluno {0} :", (i+1));
                n = int.Parse(Console.ReadLine());

                //chamando o procedimento
                Notas(n);
            }
        }
    }
}
