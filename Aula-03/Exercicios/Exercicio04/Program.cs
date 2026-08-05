internal class Program
{
    private static void Main(string[] args)
    {
        /* 
        Desenvolva um programa que simule um caixa eletrônico.
        
        O usuário informa um valor de saque.
        O sistema deve informar a quantidade de notas necessárias.
        
        # Notas disponíveis: 100, 50, 20, 10, 5, 2, 1
        
        */
        Console.Write("Digite o valor do saque: ");
        int valor = int.Parse(Console.ReadLine());

        CalcularNotas(valor);
    }

    static void CalcularNotas(int valor)
    {
        int nota100 = valor / 100;
        valor %= 100;

        int nota50 = valor / 50;
        valor %= 50;

        int nota20 = valor / 20;
        valor %= 20;

        int nota10 = valor / 10;
        valor %= 10;

        int nota5 = valor / 5;
        valor %= 5;

        int nota2 = valor / 2;
        valor %= 2;

        int nota1 = valor;

        Console.WriteLine();
        Console.WriteLine($"{nota100} notas de 100");
        Console.WriteLine($"{nota50} notas de 50");
        Console.WriteLine($"{nota20} notas de 20");
        Console.WriteLine($"{nota10} notas de 10");
        Console.WriteLine($"{nota5} notas de 5");
        Console.WriteLine($"{nota2} notas de 2");
        Console.WriteLine($"{nota1} notas de 1");
    }
}