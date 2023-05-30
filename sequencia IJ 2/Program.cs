class program
{
    static void Main()
    {
        for(int i = 1; i != 11; i += 2)
        {
            int j = 7;
            Console.WriteLine("I={0} J={1}", i, j);
            j--;
            Console.WriteLine("I={0} J={1}", i, j);
            j--;
            Console.WriteLine("I={0} J={1}", i, j);
        }
    }
}
/*Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada
Não há nenhuma entrada neste problema.

Saída
Imprima a sequencia conforme exemplo abaixo

Exemplo de Entrada	Exemplo de Saída
I=1 J=7
I=1 J=6
I=1 J=5
I=3 J=7
I=3 J=6
I=3 J=5
...
I=9 J=7
I=9 J=6
I=9 J=5*/