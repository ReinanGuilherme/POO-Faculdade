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

        public bool ChecarValor(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor de depósito deve ser maior que zero.");  
                return false;
            }
            
            return true;
        }

        public bool Depositar(float valor)
        {
            if(ChecarValor(valor)){
                Saldo += valor;
                return true;
            }

            return false;
        }

        public bool Sacar(float valor)
        {
            if (!ChecarValor(valor) || valor > Saldo)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public bool Transferir(float valor, ContaBancaria contaDestino)
        {
            if (!ChecarValor(valor) || valor > Saldo)
            {
                return false;
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
