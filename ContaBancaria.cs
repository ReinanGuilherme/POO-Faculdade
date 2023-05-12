namespace POO_TransacoesBanco
{
    public class ContaBancaria
    {
        public string Nome { get;  }
        public string Cpf { get;  }
        public int NumConta { get;  }
        public int NumAgencia { get;  }
        public float Saldo { get; private set; }
        public TipoConta Tipo { get;  }

        public ContaBancaria(string nome, string cpf, TipoConta tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Tipo = tipo;
            Saldo = 0;


            Random randNum = new Random();
            NumConta = randNum.Next(1000, 9999);
            NumAgencia = randNum.Next(100, 999);
        }

        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de depósito deve ser maior que zero.");
            }
            else
            {
                Saldo += valor;
            }
        }

        public void Sacar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de saque deve ser maior que zero.");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public void Transferir(float valor, ContaBancaria contaDestino)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de transferência deve ser maior que zero.");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }
            else
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
            }
        }
    }
}
