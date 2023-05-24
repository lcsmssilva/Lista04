using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex08
    {
        //função que retornara uma variavel double
        public static double CalculoS(int N)
        {
            //declarando variaveis e atribuindo valor

            double s = 0;
            double a = 2, b = 4;

            for (int i = 1; i <= N; i++)
            {                
                //aplicando a formula e atribuindo valor a s
                a = i * i + 1;
                b = i + 3;
                s += a / b;
            }

            return s; //retornando o valor de s para main
        }
        //procedimento MAIN
        public static void Executar()
        {
            //declarando e atribuindo a variavel n 
            int n;
            Console.WriteLine("Digite um número inteiro e positivo: ");
            //convertendo n 'string' em n 'int'
            n = int.Parse(Console.ReadLine());
            
            //declarando e atribuindo valor a variavel S
            double S = CalculoS(n);

            //imprimindo na tela o resultado
            Console.WriteLine("O valor de S é: " + S);

        }
    }    
}
