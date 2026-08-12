internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM PILHAS (FILO) ===");

        // 1 = Criar uma nova pilha vazia
        Stack<string> pilhaLivros = new Stack<string>();

        // 2 - adicionar elementos em uma pilha
        pilhaLivros.Push("Dom quixote");
        pilhaLivros.Push("O cortiço");
        pilhaLivros.Push("Harry potter");

        // 3 - percorrer todos os elementos de uma pilha
        foreach (var item in pilhaLivros)
        {
            Console.WriteLine(item);

        }

        // 4 - remover um elemento da pilha
        string livroRemovido = pilhaLivros.Pop();
        Console.WriteLine();
        Console.WriteLine($"O livro retirado foi: {livroRemovido}");

        pilhaLivros.Push("O pequeno Principe");
        Console.WriteLine();
        foreach (var item in pilhaLivros)
        {
            Console.WriteLine(item);

        }



    }
}