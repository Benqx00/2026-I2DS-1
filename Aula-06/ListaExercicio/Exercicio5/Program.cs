

internal class Program
{
    private static void Main(string[] args)
{
    Stack<string> historico = new Stack<string>();

        historico.Push("Digitar");
        historico.Push("Colar");
        historico.Push("Negrito");
        historico.Push("Apagar");
        
        string acaoDesfeita = historico.Pop();
        Console.WriteLine("Ação desfeita: " + acaoDesfeita);

        acaoDesfeita = historico.Pop();
        Console.WriteLine("Ação desfeita: " + acaoDesfeita);
}
}