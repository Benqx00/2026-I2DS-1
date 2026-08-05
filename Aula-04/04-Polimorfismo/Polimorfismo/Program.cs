using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Polimorfismo: um objeto pode ser tratado de maneiras diferentes, dependendo do contexto que é utilizado. */

        Gato gato = new Gato();
        Cachorro dog = new Cachorro();

        gato.Nome = "Bichano";
        gato.FazerBarulho();

        dog.Nome = "Geraldo";
        dog.FazerBarulho();
    }

    // Super Classe 
    public class Animal
    {
        public string Nome {get; set;}
        public virtual void FazerBarulho()
        {
            Console.WriteLine("Todo animal faz um barulho");
        }
    }
    //Classe Filha
    public class Cachorro : Animal
    {
        public override void FazerBarulho()
        {
            Console.WriteLine("AU AU AU");
        }
    }
    //Classe Filha
    public class Gato : Animal
    {
        public override void FazerBarulho()
        {
            Console.WriteLine("MIAU MIAU");
        }
    }
}