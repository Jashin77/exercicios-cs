using System;

class program
{
    static void Main()
    {
        int i = 1; int j = 60;
        while (j >= 0)
        {
            Console.WriteLine("I={0} J={1}",i,j);
            i += 3;
            j -= 5;
        }
    }
}
/*Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada
Não há nenhuma entrada neste problema.

Saída
Imprima a sequencia conforme exemplo abaixo

Exemplo de Entrada	Exemplo de Saída
I=1 J=60
I=4 J=55
I=7 J=50
...
I=? J=0*/