
﻿public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Teclado", Preco = 39.00 },
            new Produto { Nome = "Mouse", Preco = 53.50 },
            new Produto { Nome = "Fone de Ouvido", Preco = 144.99 },
            new Produto { Nome = "Monitor", Preco = 150.50 },
            new Produto { Nome = "Mousepad XL", Preco = 75.00 }
        };

        var produtosCaros = produtos.Where(p => p.Preco > 50.00);

        Console.WriteLine("Produtos com preço maior que R$ 50,00:");
        foreach (var prod in produtosCaros)
        {
            Console.WriteLine($"- {prod.Nome}: R$ {prod.Preco:F2}");
        }
    }
}