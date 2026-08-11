using System;

public class Personagem
{
    public string Nome { get; private set; }
    public int Nivel { get; private set; }
    public int Experiencia { get; private set; }

    public int Forca { get; protected set; }
    public int Agilidade { get; protected set; }
    public int Inteligencia { get; protected set; }
    public int Vida { get; protected set; }

    public Personagem(
        string nome,
        int forca,
        int agilidade,
        int inteligencia,
        int vida)
    {
        Nome = nome;
        Nivel = 1;
        Experiencia = 0;

        Forca = forca;
        Agilidade = agilidade;
        Inteligencia = inteligencia;
        Vida = vida;
    }

    public virtual void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"Experiência: {Experiencia}");
        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine($"Agilidade: {Agilidade}");
        Console.WriteLine($"Inteligência: {Inteligencia}");
        Console.WriteLine($"Vida: {Vida}");
    }

    public virtual void Atacar(Personagem alvo)
    {
        int dano = Forca;

        Console.WriteLine($"{Nome} atacou {alvo.Nome}!");

        alvo.Defender(dano);

        GanharExperiencia(20);
    }

    public virtual void Defender(int dano)
    {
        int danoRecebido = dano - Agilidade;

        if (danoRecebido < 1)
        {
            danoRecebido = 1;
        }

        Vida -= danoRecebido;

        if (Vida < 0)
        {
            Vida = 0;
        }

        Console.WriteLine($"Dano recebido: {danoRecebido}");
        Console.WriteLine($"Vida de {Nome}: {Vida}");
    }

    public void GanharExperiencia(int experiencia)
    {
        Experiencia += experiencia;

        Console.WriteLine(
            $"{Nome} ganhou {experiencia} XP!"
        );

        VerificarEvolucao();
    }

    private void VerificarEvolucao()
    {
        int experienciaNecessaria = Nivel * 100;

        if (Experiencia >= experienciaNecessaria)
        {
            Evoluir();
        }
    }

    protected virtual void Evoluir()
    {
        Nivel++;

        Forca += 2;
        Agilidade += 2;
        Inteligencia += 2;
        Vida += 20;

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("              LEVEL UP!");
        Console.WriteLine("========================================");

        Console.WriteLine(
            $"{Nome} evoluiu para o nível {Nivel}!"
        );

        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine($"Agilidade: {Agilidade}");
        Console.WriteLine($"Inteligência: {Inteligencia}");
        Console.WriteLine($"Vida: {Vida}");

        Console.WriteLine("========================================");
        Console.WriteLine();
    }

    public bool EstaVivo()
    {
        return Vida > 0;
    }
}


// ======================================================
// MAGO
// ======================================================

public class Mago : Personagem
{
    public Mago(string nome)
        : base(
            nome,
            5,
            5,
            15,
            80)
    {
    }

    public override void Atacar(Personagem alvo)
    {
        int dano = Inteligencia;

        Console.WriteLine(
            $"{Nome} lançou uma magia contra {alvo.Nome}!"
        );

        alvo.Defender(dano);

        GanharExperiencia(20);
    }

    protected override void Evoluir()
    {
        NivelUp();

        Inteligencia += 5;
        Agilidade += 2;
        Vida += 15;

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("              LEVEL UP!");
        Console.WriteLine("========================================");

        Console.WriteLine(
            $"{Nome} evoluiu para o nível {Nivel}!"
        );

        Console.WriteLine($"Inteligência: {Inteligencia}");
        Console.WriteLine($"Agilidade: {Agilidade}");
        Console.WriteLine($"Vida: {Vida}");

        Console.WriteLine("========================================");
        Console.WriteLine();
    }

    private void NivelUp()
    {
        typeof(Personagem)
            .GetProperty("Nivel")!
            .SetValue(this, Nivel + 1);
    }
}


// ======================================================
// ELFO
// ======================================================

public class Elfo : Personagem
{
    public Elfo(string nome)
        : base(
            nome,
            8,
            15,
            10,
            100)
    {
    }

    public override void Atacar(Personagem alvo)
    {
        int dano = Forca + Agilidade / 2;

        Console.WriteLine(
            $"{Nome} disparou um ataque rápido contra {alvo.Nome}!"
        );

        alvo.Defender(dano);

        GanharExperiencia(20);
    }

    protected override void Evoluir()
    {
        NivelUp();

        Agilidade += 5;
        Forca += 2;
        Vida += 20;

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("              LEVEL UP!");
        Console.WriteLine("========================================");

        Console.WriteLine(
            $"{Nome} evoluiu para o nível {Nivel}!"
        );

        Console.WriteLine($"Agilidade: {Agilidade}");
        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine($"Vida: {Vida}");

        Console.WriteLine("========================================");
        Console.WriteLine();
    }

    private void NivelUp()
    {
        typeof(Personagem)
            .GetProperty("Nivel")!
            .SetValue(this, Nivel + 1);
    }
}


// ======================================================
// CAVALEIRO
// ======================================================

public class Cavaleiro : Personagem
{
    public Cavaleiro(string nome)
        : base(
            nome,
            15,
            8,
            5,
            150)
    {
    }

    public override void Atacar(Personagem alvo)
    {
        int dano = Forca + 5;

        Console.WriteLine(
            $"{Nome} golpeou {alvo.Nome}!"
        );

        alvo.Defender(dano);

        GanharExperiencia(20);
    }

    public override void Defender(int dano)
    {
        int danoRecebido = dano - 5;

        if (danoRecebido < 1)
        {
            danoRecebido = 1;
        }

        Vida -= danoRecebido;

        if (Vida < 0)
        {
            Vida = 0;
        }

        Console.WriteLine(
            $"{Nome} bloqueou parte do ataque."
        );

        Console.WriteLine(
            $"Dano recebido: {danoRecebido}"
        );

        Console.WriteLine(
            $"Vida de {Nome}: {Vida}"
        );
    }

    protected override void Evoluir()
    {
        NivelUp();

        Forca += 5;
        Vida += 30;

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("              LEVEL UP!");
        Console.WriteLine("========================================");

        Console.WriteLine(
            $"{Nome} evoluiu para o nível {Nivel}!"
        );

        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine($"Vida: {Vida}");

        Console.WriteLine("========================================");
        Console.WriteLine();
    }

    private void NivelUp()
    {
        typeof(Personagem)
            .GetProperty("Nivel")!
            .SetValue(this, Nivel + 1);
    }
}


// ======================================================
// PROGRAMA PRINCIPAL
// ======================================================

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       JOGO DE BATALHA - POO");
        Console.WriteLine("========================================");

        Console.WriteLine();

        Personagem personagem1 = CriarPersonagem(1);

        Console.WriteLine();

        Personagem personagem2 = CriarPersonagem(2);

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          PERSONAGENS ESCOLHIDOS");
        Console.WriteLine("========================================");

        Console.WriteLine();

        personagem1.Apresentar();

        Console.WriteLine();

        personagem2.Apresentar();

        Console.WriteLine();

        Console.WriteLine("Pressione ENTER para iniciar a batalha...");
        Console.ReadLine();

        IniciarBatalha(personagem1, personagem2);
    }


    static Personagem CriarPersonagem(int numero)
    {
        Console.WriteLine();
        Console.WriteLine($"Escolha o tipo do Personagem {numero}:");
        Console.WriteLine();
        Console.WriteLine("1 - Mago");
        Console.WriteLine("2 - Elfo");
        Console.WriteLine("3 - Cavaleiro");
        Console.WriteLine();

        int opcao;

        while (!int.TryParse(Console.ReadLine(), out opcao)
               || opcao < 1
               || opcao > 3)
        {
            Console.WriteLine(
                "Opção inválida. Digite 1, 2 ou 3:"
            );
        }

        Console.WriteLine();
        Console.Write($"Digite o nome do Personagem {numero}: ");

        string nome = Console.ReadLine()!;

        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.Write("Digite um nome válido: ");
            nome = Console.ReadLine()!;
        }

        switch (opcao)
        {
            case 1:
                return new Mago(nome);

            case 2:
                return new Elfo(nome);

            case 3:
                return new Cavaleiro(nome);

            default:
                return new Mago(nome);
        }
    }


    static void IniciarBatalha(
        Personagem personagem1,
        Personagem personagem2)
    {
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          INÍCIO DA BATALHA");
        Console.WriteLine("========================================");

        Console.WriteLine();
        Console.WriteLine(
            $"{personagem1.Nome} VS {personagem2.Nome}"
        );

        Console.WriteLine();

        int rodada = 1;

        while (
            personagem1.EstaVivo() &&
            personagem2.EstaVivo())
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"RODADA {rodada}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            // Personagem 1 ataca
            personagem1.Atacar(personagem2);

            if (!personagem2.EstaVivo())
            {
                break;
            }

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();

            Console.WriteLine();

            // Personagem 2 ataca
            personagem2.Atacar(personagem1);

            if (!personagem1.EstaVivo())
            {
                break;
            }

            Console.WriteLine();

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();

            rodada++;
        }

        ExibirResultado(personagem1, personagem2);
    }


    static void ExibirResultado(
        Personagem personagem1,
        Personagem personagem2)
    {
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("             FIM DA BATALHA");
        Console.WriteLine("========================================");

        Console.WriteLine();

        Personagem vencedor;

        if (personagem1.EstaVivo())
        {
            vencedor = personagem1;
        }
        else
        {
            vencedor = personagem2;
        }

        Console.WriteLine(
            $"VENCEDOR: {vencedor.Nome}"
        );

        Console.WriteLine();

        Console.WriteLine("========== STATUS DO VENCEDOR ==========");

        vencedor.Apresentar();

        Console.WriteLine();

        Console.WriteLine("========================================");
        Console.WriteLine("              FIM DO JOGO");
        Console.WriteLine("========================================");
    }
}