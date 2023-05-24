using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex09
    {
        //função para calcular a media das notas
        public static double MediaNotas(double r, double t)
        {
            //declarando e já atribuindo valor a variavel
            double media = r/ t;

            //retorna media
            return media;
        } 

        //procedimento MAIN
        public static void Executar()
        {
            //declarando e atribuindo valor a variavel
            int notas = 1;
            double no = 0; //numero de notas acima de 6
            double resultado = 0;

            //estrutura de repetição
            do
            {
                //alterando valor a variavel notas
                Console.WriteLine("Insira a nota do aluno:   (Insira -1 para finalizar)");
                notas = int.Parse(Console.ReadLine());

                //se notas maior ou igual a 6
                if (notas >= 6)
                {
                    resultado += notas;
                    no++;//aumento em 1 o numero de notas
                }

            } while (notas > -1); //enquanto notas for maior que -1
            Console.WriteLine("A média de notas de {0} alunos aprovados é: {1}", no, MediaNotas(resultado, no));
        }
    }
}
