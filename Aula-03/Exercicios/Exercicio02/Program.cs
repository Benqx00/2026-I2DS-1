internal class Program
{
    private static void Main(string[] args)
    {
        /*  Criar uma calculadora utilizando estruturas condicionais e métodos.
            Conceitos utilizados:
            - Switch;
            - Métodos;
            - Retorno de valores;
            - Operações matemáticas.

            # Enunciado
            Desenvolva uma calculadora que permita ao usuário escolher uma operação matemática.
            O sistema deve possuir as operações:
            1 - Soma
            2 - Subtração
            3 - Multiplicação
            4 - Divisão

            # Requisitos

            O programa deve:

            1. Solicitar dois números;
            2. Apresentar um menu de operações;
            3. Executar a operação escolhida;
            4. Exibir o resultado.
        */
        int num1;
        int num2;
        Console.Write("Digite o Primeiro Número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        string operacao;
        
        Console.Write("Selecione uma Operação: ");
        operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1": 
                Console.WriteLine(num1 + num2);
                break;
            case "2": 
                Console.WriteLine(num1 - num2);
                break;
            case "3": 
                Console.WriteLine(num1 * num2);
                break;
            case "4": 
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Operador informado não é válido.");
                break;
        }
    }
}