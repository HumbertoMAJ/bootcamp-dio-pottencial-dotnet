﻿using System;

class DIO
{

    static void Main(string[] args)
    {
       
        int qt = int.Parse(Console.ReadLine());

        string[] v = new string[qt];

        for (int i = 0; i < qt; i++)
        {
            
            v = Console.ReadLine().Split(" ");

            string a = v[0];
            string b = v[1];

            if (a.Length > 0 && a.Length <= 1000 && b.Length < 0 && b.Length >= 1000)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }

    }

}
