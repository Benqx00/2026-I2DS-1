internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Livro
        Aluno aluno1 = new Aluno();
        aluno1.Rm = "4104";
        aluno1.Nome = "Samuel garcia Vasconellos";
        aluno1.Nascimento = "14/09/2009";
        aluno1.Email ="samuelgarcia2009@gmail.com";

        //segundo livro
        Aluno aluno2 = new Aluno();
        aluno2.Rm = "4101";
        aluno2.Nome = "Porca frita";
        aluno2.Nascimento = "20/01/2010";
        aluno2.Email ="porcafrita@outlook.com";

        //terceiro livro
        Aluno aluno3 = new Aluno();
        aluno3.Rm = "41009";
        aluno3.Nome = "Cachoera candelaria";
        aluno3.Nascimento = "20/01/2010";
        aluno3.Email ="dentuço@gmail.com";

        Aluno aluno4 = new Aluno();
        aluno4.Rm = "41032";
        aluno4.Nome = "junior";
        aluno4.Nascimento = "14/09/2004";
        aluno4.Email ="junioremae@gmail.com";

        // Exibindo os Livro na Tela 
        Console.WriteLine("==== LIVROS ====");
        Console.WriteLine($"\nAluno 01: {aluno1.Nome} | Autor: {aluno1.Email}");
        Console.WriteLine($"\nAluno 02: {aluno2.Nome} | Autor: {aluno2.Email}");
        Console.WriteLine($"\nAluno 03: {aluno3.Nome} | Autor: {aluno3.Email}");
        Console.WriteLine($"\nAluno 04: {aluno4.Nome} | Autor: {aluno4.Email}");
    }

    public class Aluno
    {
        public string Rm {get; set;}
        public string Nome {get; set;}
        public string Nascimento {get; set;}
        public string Email {get; set;}
    }
}