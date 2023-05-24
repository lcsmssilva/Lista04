using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex01
    {
        static void CalculaMediaNota(double n1, double n2, double n3, char l)
        {
            double media = 0;
            if (l == 'a' || l == 'A') //se l for a
            {
                media = (n1 + n2 + n3) / 3; //media aritmetica soma dos valores dividido pela quantidade de valores
                Console.WriteLine("A média desse aluno é: {0}\n", media);
            }
            else if (l == 'r' || l == 'R')
            {
                media = (n1 * 5 + n2 * 3 + n3 * 2) / 3;
                Console.WriteLine("A média desse aluno é: {0}\n", media);
                /*media ponderada é o primeiro valor * o numero indicado
                o segundo valor * o valor indicado*/
            }
        }

        public static void Executar()
        {
            int n;
            Console.WriteLine("Insira a quantidade de alunos: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
                //declarando variaveis numero 1, numero 2 e numero 3 e atribuindo valores
                double n1;
                Console.WriteLine("Insira a primeira nota: ");
                n1 = double.Parse(Console.ReadLine());

                double n2;
                Console.WriteLine("Insira a segunda nota: ");
                n2 = double.Parse(Console.ReadLine());

                double n3;
                Console.WriteLine("Insira a terceira nota: ");
                n3 = double.Parse(Console.ReadLine());

                //declarando variavel caractere l e atribuindo valor
                char l;
                Console.WriteLine("Insira o caractere 'a' para média áritmetica ou\ninsira o caractere 'r' para média ponderada.");
                l = char.Parse(Console.ReadLine());

                //chamando o procedimento
                CalculaMediaNota(n1, n2, n3, l); 
            }
        }
    }
}
