

internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();

        fila.Enqueue("Ana");
        fila.Enqueue("Joao");
        fila.Enqueue("Pedro");
        fila.Enqueue("Dias");
        fila.Enqueue("Neto");

        fila.Dequeue();
        fila.Dequeue();

        foreach (var pessoas in fila)
        {
            Console.WriteLine(pessoas);
        }

    }
}