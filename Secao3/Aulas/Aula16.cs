using System;


namespace Aula16
{
    class aula16
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';     //para um caractere utilizar apenas aspas simples
            char letra = '\u0041'; //utilizando unicode
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;

            int n7 = int.MinValue;  //para saber o menor valor
            int n8 = int.MaxValue;  //para saber o maior valor


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
        }
    }
}