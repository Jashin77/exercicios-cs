﻿namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j1 = 7; int j2 = 6; int j3 = 5;
            for(int i = 1; i != 11; i += 2)
            {
                Console.WriteLine("I={0} J={1}", i, j1);
                Console.WriteLine("I={0} J={1}", i, j2);
                Console.WriteLine("I={0} J={1}", i, j3);
                j1 += 2;
                j2 += 2;
                j3 += 2;
            }
        }
    }
}
/*Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada
Não há nenhuma entrada neste problema.

Saída
Imprima a sequencia conforme exemplo abaixo.

Exemplo de Entrada	Exemplo de Saída
I=1 J=7
I=1 J=6
I=1 J=5
I=3 J=9
I=3 J=8
I=3 J=7
...
I=9 J=15
I=9 J=14
I=9 J=13*/