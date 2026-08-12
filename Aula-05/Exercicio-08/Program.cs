internal class Program
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public int Nivel { get; protected set; }
        public int Forca { get; protected set; }
        public int Agilidade { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Vida { get; protected set; }

        public Personagem(string nome, int nivel, int forca, int agilidade, int inteligencia, int vida)
        {
            Nome = nome;
            Nivel = nivel;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Sou {Nome}, nível {Nivel}. Vida: {Vida}, Inteligência {Inteligencia}");
        }

        public virtual void Atacar(Personagem alvo)
        {
            int dano = Forca;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {dano} de dano!");
            alvo.ReceberDano(dano);
        }

        public void ReceberDano(int dano)
        {
            if (dano <= 0) return;
            Vida -= dano;
            if (Vida < 0) Vida = 0;
            Console.WriteLine($"{Nome} sofreu {dano} de dano! Vida atual: {Vida}");
        }

        public bool EstaVivo()
        {
            return this.Vida > 0;
        }
    }

    public class Mago : Personagem
    {
        public int Mana { get; protected set; }

        public Mago(string nome, int nivel, int forca, int agilidade, int inteligencia, int vida, int mana)
            : base(nome, nivel, forca, agilidade, inteligencia, vida)
        {
            this.Mana = mana;
        }

        public override void Atacar(Personagem alvo)
        {
            if (this.Mana < 10)
            {
                Console.WriteLine($"{this.Nome} não tem mana suficiente e ataca no braço mesmo!");
                alvo.ReceberDano(this.Forca);
                return;
            }

            this.Mana -= 10;
            int dano = this.Inteligencia * 2;
            Console.WriteLine($"{this.Nome} lança exercicios de 25 questoes em {alvo.Nome} causando {dano} de cansaço! (Mana restante: {this.Mana})");
            alvo.ReceberDano(dano);
        }
    }

    public class Elfo : Personagem
    {
        public Elfo(string nome, int nivel, int forca, int agilidade, int inteligencia, int vida)
            : base(nome, nivel, forca, agilidade, inteligencia, vida) {}

        public override void Atacar(Personagem alvo)
        {
            int dano = this.Agilidade + (this.Forca / 2);
            Console.WriteLine($"{this.Nome} dispara o aviso que tem gente de fora vindo nos visitar em {alvo.Nome} causando {dano} de chatice!");
            alvo.ReceberDano(dano);
        }
    }

    public class Diretor : Personagem
    {
        public int Autoridade { get; protected set; }

        public Diretor(string nome, int nivel, int forca, int agilidade, int inteligencia, int vida, int autoridade)
            : base(nome, nivel, forca, agilidade, inteligencia, vida)
        {
            this.Autoridade = autoridade;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = this.Autoridade + (this.Inteligencia / 2);
            Console.WriteLine($"{this.Nome} fura o pneu do carro às 7 da manhã de {alvo.Nome}, causando {dano} de estresse!");
            alvo.ReceberDano(dano);
        }
    }

    
    private static int ContarVivos(Personagem[] lutadores)
    {
        int vivos = 0;
        for (int i = 0; i < lutadores.Length; i++)
        {
            if (lutadores[i].EstaVivo())
            {
                vivos++;
            }
        }
        return vivos;
    }

    
    private static Personagem PegarVencedor(Personagem[] lutadores)
    {
        for (int i = 0; i < lutadores.Length; i++)
        {
            if (lutadores[i].EstaVivo())
            {
                return lutadores[i];
            }
        }
        return null;
    }

    private static void Main(string[] args)
    {
        Mago mago = new Mago("sa", 5, 6, 8, 20, 80, 50);
        Elfo elfo = new Elfo("Cristiano", 4, 10, 18, 10, 90);
        Diretor diretor = new Diretor("Benqx", 6, 10, 6, 18, 100, 20);

        Personagem[] lutadores = { mago, elfo, diretor };

        Console.WriteLine("=== BATALHA RPG: TODOS CONTRA TODOS ===");
        for (int i = 0; i < lutadores.Length; i++)
        {
            lutadores[i].Apresentar();
        }
        Console.WriteLine("\nPressione ENTER para iniciar a batalha...");
        Console.ReadLine();

        int turno = 0;
        int indiceAtual = 0;

        while (ContarVivos(lutadores) > 1)
        {
            Personagem atacante = lutadores[indiceAtual];

            if (!atacante.EstaVivo())
            {
                indiceAtual = (indiceAtual + 1) % lutadores.Length;
                continue;
            }

            Personagem alvo = null;
            for (int i = 1; i < lutadores.Length; i++)
            {
                int idx = (indiceAtual + i) % lutadores.Length;
                if (lutadores[idx].EstaVivo())
                {
                    alvo = lutadores[idx];
                    break;
                }
            }

            if (alvo == null)
            {
                break;
            }

            turno++;
            Console.WriteLine($"\n--- Turno {turno} ---");
            atacante.Atacar(alvo);

            if (!alvo.EstaVivo())
            {
                Console.WriteLine($"{alvo.Nome} foi derrotado!");
            }

            if (ContarVivos(lutadores) <= 1)
            {
                Personagem vencedor = PegarVencedor(lutadores);
                Console.WriteLine($"\n{vencedor.Nome} venceu a batalha!");
                break;
            }

            Console.WriteLine("Pressione qualquer tecla para o próximo turno...");
            Console.ReadKey(true);

            indiceAtual = (indiceAtual + 1) % lutadores.Length;
        }

        Console.WriteLine("\nFim de jogo. Pressione ENTER para sair.");
        Console.ReadLine();
        
    }
}