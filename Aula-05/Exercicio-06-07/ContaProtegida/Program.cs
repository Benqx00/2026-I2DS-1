internal class Program
{
    public class ContaBancaria
    {
        public string Banco { get; private set; }
        public string Agencia { get; private set; }
        public string Conta { get; private set; }
        public double Saldo { get; protected set; }

        public ContaBancaria(string banco, string agencia, string conta, double saldo)
        {
            this.Banco = banco;
            this.Agencia = agencia;
            this.Conta = conta;
            this.Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito inválido!");
                return;
            }

            this.Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        }

        
        public virtual void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido!");
                return;
            }

            if (valor > this.Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
                return;
            }

            this.Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }
    }

    public class ContaCorrente : ContaBancaria
    {
        public double LimiteChequeEspecial { get; private set; }

        public ContaCorrente(string banco, string agencia, string conta, double saldo, double limiteChequeEspecial)
            : base(banco, agencia, conta, saldo)
        {
            this.LimiteChequeEspecial = limiteChequeEspecial;
        }

        
        public override void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido!");
                return;
            }

            if (valor > this.Saldo + this.LimiteChequeEspecial)
            {
                Console.WriteLine("Saldo e limite insuficientes para realizar o saque!");
                return;
            }

            this.Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }
    }

    private static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente("Banco do Brasil", "1234-5", "98765-4", 500.00, 300.00);
        ContaCorrente conta2 = new ContaCorrente("Itaú", "4321-0", "11122-3", 1000.00, 500.00);
        ContaCorrente conta3 = new ContaCorrente("Caixa Econômica", "5678-9", "33344-5", 200.00, 100.00);

        Console.WriteLine("=== CONTAS CORRENTES ===");

        Console.WriteLine("\nConta 1");
        Console.WriteLine($"Banco: {conta1.Banco}");
        Console.WriteLine($"Agência: {conta1.Agencia}");
        Console.WriteLine($"Conta: {conta1.Conta}");
        Console.WriteLine($"Saldo: R$ {conta1.Saldo:F2}");
        Console.WriteLine($"Limite cheque especial: R$ {conta1.LimiteChequeEspecial:F2}");
        conta1.Depositar(100.00);
        conta1.Sacar(750.00);
        Console.WriteLine($"Saldo final: R$ {conta1.Saldo:F2}");

        Console.WriteLine("\nConta 2");
        Console.WriteLine($"Banco: {conta2.Banco}");
        Console.WriteLine($"Agência: {conta2.Agencia}");
        Console.WriteLine($"Conta: {conta2.Conta}");
        Console.WriteLine($"Saldo: R$ {conta2.Saldo:F2}");
        Console.WriteLine($"Limite cheque especial: R$ {conta2.LimiteChequeEspecial:F2}");
        conta2.Sacar(1200.00);
        Console.WriteLine($"Saldo final: R$ {conta2.Saldo:F2}");

        Console.WriteLine("\nConta 3");
        Console.WriteLine($"Banco: {conta3.Banco}");
        Console.WriteLine($"Agência: {conta3.Agencia}");
        Console.WriteLine($"Conta: {conta3.Conta}");
        Console.WriteLine($"Saldo: R$ {conta3.Saldo:F2}");
        Console.WriteLine($"Limite cheque especial: R$ {conta3.LimiteChequeEspecial:F2}");
        conta3.Sacar(500.00);
        Console.WriteLine($"Saldo final: R$ {conta3.Saldo:F2}");
    }
}