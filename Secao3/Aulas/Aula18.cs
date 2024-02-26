using System;
using System.Globalization;

namespace Aulas
{
    internal class Aula18
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia !");  //Imprime na tela
            Console.WriteLine("Boa tarde!"); //WriteLine - Imprime na tela incluindo uma quebra de linha no final
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-------------------------");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2")); //imprimir com 2 casa decimais
            Console.WriteLine(saldo.ToString("F4")); //imprimir com 4 casa decimais
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture)); //imprimir com .(ponto)
            Console.WriteLine(nome);

            //Placeholdes
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igaul a {saldo:F2} reais");

            //Concatenização (unica opcao para usar o CultureInfo.InvariantCulture)
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
        }
    }
}

