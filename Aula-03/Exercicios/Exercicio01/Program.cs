internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Desenvolva um programa que permita ao usuário informar uma temperatura em graus Celsius e realizar a conversão para Fahrenheit.
            A fórmula utilizada é: Fahrenheit = (Celsius * 9 / 5) + 32
            # Requisitos
            
            O programa deve:
            1. Solicitar uma temperatura em Celsius;
            2. Realizar a conversão;
            3. Exibir o resultado em Fahrenheit.
        */

        int celsius;
        Console.Write("Digite a temperatura em Graus Celsius: ");
        celsius = int.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
    }
}