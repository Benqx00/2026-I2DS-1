internal class Program
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 10;

            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
        }
    }

    private static void Main(string[] args)
    {
        Carro carro1 = new Carro();
        carro1.Marca = "Fiat";
        carro1.Modelo = "Siena";
        carro1.Velocidade = 100;

        Carro carro2 = new Carro();
        carro2.Marca = "Volkswagen";
        carro2.Modelo = "Gol";
        carro2.Velocidade = 150;

        Carro carro3 = new Carro();
        carro3.Marca = "Ford";
        carro3.Modelo = "Ka";
        carro3.Velocidade = 300000;



        Console.WriteLine("Carro 1");
        Console.WriteLine("Marca: " + carro1.Marca);
        Console.WriteLine("Modelo: " + carro1.Modelo);
        Console.WriteLine("Velocidade: " + carro1.Velocidade + " km/h");

        

        Console.WriteLine("Carro 2");
        Console.WriteLine("Marca: " + carro2.Marca);
        Console.WriteLine("Modelo: " + carro2.Modelo);
        Console.WriteLine("Velocidade: " + carro2.Velocidade + " km/h");

    
        Console.WriteLine("Carro 3");
        Console.WriteLine("Marca: " + carro3.Marca);
        Console.WriteLine("Modelo: " + carro3.Modelo);
        Console.WriteLine("Velocidade: " + carro3.Velocidade + " km/h");
    }
}