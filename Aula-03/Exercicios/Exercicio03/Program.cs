internal class Program
{
    private static void Main(string[] args)
    {
        /* 
        ## Objetivo: Criar um sistema que calcule a média de um aluno e informe sua situação.
        
        Conceitos utilizados:
        - Variáveis;
        - Condições;
        - Operadores relacionais;
        - Métodos.

        # Enunciado: Desenvolva um programa escolar que receba:
        - Nome do aluno;
        - Três notas.

        O sistema deve calcular a média final.
        
        # Regras
        Caso a média seja: Maior ou igual a 7 -> Aprovado
                           Entre 5 e 6.9 -> Recuperação
                           Menor que 5 ->Reprovado
        */

        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());


        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());


        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());


        double media = CalcularMedia(nota1,nota2,nota3);

        string situacao = VerificarSituacao(media);

        Console.WriteLine();

        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Média: {media:F1}");
        Console.WriteLine($"Situação: {situacao}");
    }


    static double CalcularMedia(double n1,double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }


    static string VerificarSituacao(double media)
    {
        if(media >= 7)
        {
            return "Aprovado";
        }
        else if(media >= 5)
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }
}