internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FILAS ===");

        // 1 - Criar uma nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("DIPA");      // 0
        filaBanco.Enqueue("SÁ");        // 1
        filaBanco.Enqueue("BENQX");     // 2
        filaBanco.Enqueue("Mirto");     // 3

        // 3 -  Percorrer elementos de uma fila
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Retirar um elemento da lista
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O nome chamado foi: {pessoaRetirada}");
        filaBanco.Enqueue("Mirto");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 5- verificar se existe de um determinado elemento na lista
        string procurar = "Mirto";
        bool achou =  filaBanco.Contains(procurar);

        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila! ");
        }
        else
        {
            Console.WriteLine($"{procurar} não está na fila! ");
        }

        
    }
}