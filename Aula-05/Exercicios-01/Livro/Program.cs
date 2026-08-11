internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Livro
        Livro livro1 = new Livro();
        livro1.Titulo = "O senhor dos Anéis";
        livro1.Autor = "J.R.R Tolkien";
        livro1.Editora = "HarperCollins";
        livro1.AnoLancamento ="1954";

        //segundo livro
        Livro livro2 = new Livro();
        livro2.Titulo = "dipa e seus alunos ";
        livro2.Autor = "Dipa de paula";
        livro2.Editora = "paula recorders";
        livro2.AnoLancamento ="2026";

        //terceiro livro
        Livro livro3 = new Livro();
        livro3.Titulo = "nando brock pancada ";
        livro3.Autor = "sá";
        livro3.Editora = "Paulo campana";
        livro3.AnoLancamento ="1666";

        // Exibindo os Livro na Tela 
        Console.WriteLine("==== LIVROS ====");
        Console.WriteLine($"\nLivro 01: {livro1.Titulo} | Autor: {livro1.Autor}");
        Console.WriteLine($"\nLivro 02: {livro2.Titulo} | Autor: {livro2.Autor}");
        Console.WriteLine($"\nLivro 03: {livro3.Titulo} | Autor: {livro3.Autor}");


    }

    public class Livro
    {
        public string Titulo {get; set;}
        public string Autor {get; set;}
        public string Editora {get; set;}
        public string AnoLancamento {get; set;}
    }
}