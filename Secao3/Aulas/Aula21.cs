﻿using System;

namespace Aula21
{
    class Aula21
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            //int n4 = 10 / 8;
            //double n4 = (double)10 / 8;
            double n4 = 10.0 / 8; //um dos 2 valores tem q estar com o ponto

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
        }

    }
}