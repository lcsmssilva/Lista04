using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04ATP
{
    public static class Ex10
    {
        //função para definir a categoria da variavel
        public static char Categoria(int idade)
        {
            //decalrando e atribuindo valor a variavel
            char categ = '0';
            
            //utilizando if para definir qual a categoria(categ) da variavel
            if (idade > 4 && idade < 8)
            {
                categ = 'F';
            }
            else if (idade > 7 && idade < 11)
            {
                categ = 'E';
            }
            else if (idade > 10 && idade < 14)
            {
                categ = 'D';
            }
            else if (idade > 13 && idade < 16)
            {
                categ = 'C';
            }
            else if (idade > 15 && idade < 18)
            {
                categ = 'B';
            }
            else if (idade > 17)
            {
                categ = 'A';
            }
            return categ;
        }

        public static void Executar()
        {
            //declarando e atribuindo variavel
            int id, i = 1;

            do
            {
                Console.WriteLine("Insira a idade do nadador {0}:   'Insira 0 para cancelar'", i);
                id = int.Parse(Console.ReadLine());

                //se if for igual a 5 ou maior executar comando abaixo
                if (id >= 5) 
                {
                    Console.WriteLine("\nO nadador {0} é categoria {1}\n", i, Categoria(id));
                    i++;
                }
                //se if for menor que 5
                else
                {
                    Console.WriteLine("\nO nadador tem 4 anos de idade ou menos.");
                }
            } while (id > 0); //executar a repetição enquanto id for maior que 0
        }
    }
}
