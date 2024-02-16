using System;


namespace Aula15
{
    class aula15
    {
        static void Main(string[] args)
        {
            byte  n0 = 126;
            sbyte n1 = 127;  //valor maximo que um sbyte pode receber
            int n2 = 1000;
            int n3 = 214748364; //valor maximo que um int pode receber
            long n4 = 214748368L; //para utilizar numeros maiores é recomendavel usar o L no final


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
