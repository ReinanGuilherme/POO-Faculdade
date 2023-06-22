using System.Security.Cryptography;
using System.Text;

namespace POO_TransacoesBanco
{
    public abstract class ContaBancaria
    {
        private string Nome;
        private int Agencia;
        private int DgAgencia;
        private int NrConta;
        private int DgConta;
        private double Saldo;
        private string ChavePix;

        public ContaBancaria(string Nome, int Ag, int DgAg, int Conta, int DgConta)
        {
            this.Nome = Nome;
            this.Agencia = Ag;
            this.DgAgencia = DgAg;
            this.NrConta = Conta;
            this.DgConta = DgConta;
            this.Saldo = 0;
            this.ChavePix = CriandoHashChavePix();
        }

        private string CriandoHashChavePix()
        {
            byte[] randomBytes = new byte[16]; // Define o tamanho do array de bytes

            using (RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(randomBytes); // Preenche o array de bytes com valores aleatórios
            }

            StringBuilder sb = new StringBuilder();

            foreach (byte b in randomBytes)
            {
                sb.Append(b.ToString("X2")); // Converte cada byte em uma representação hexadecimal
            }

            return sb.ToString();
        }

        public string GetChavePix()
        {
            return this.ChavePix;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public int GetAgencia()
        {
            return this.Agencia;
        }

        public void SetAgencia(int agencia)
        {
            this.Agencia = agencia;
        }

        public int GetDgAgencia()
        {
            return this.DgAgencia;
        }

        public int GetConta()
        {
            return this.NrConta;
        }

        public void SetConta(int conta)
        {
            this.NrConta = conta;
        }

        public int GetDgConta()
        {
            return this.DgConta;
        }

        public void SetDgConta(int digito)
        {
            this.DgConta = digito;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public void SetSaldo(double valor)
        {
            this.Saldo = valor;
        }

        public bool CheckValor(double value)
        {
            if (value > 0)
            {
                return true;
            }
            Console.WriteLine("Valor inválido passado como parâmetro para execução da operação!");
            return false;
        }

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
        public abstract void Transferir(ContaBancaria contaDestino, double valorTransferencia);
        public abstract void RealizarPix(double valor, string nomeDestinatario, ContaBancaria contaDestino, string chavePix);

        public void Imprimir()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Agência: " + Agencia);
            Console.WriteLine("Dg Agência: " + DgAgencia);
            Console.WriteLine("Conta: " + NrConta);
            Console.WriteLine("Dg Conta: " + DgConta);
            Console.WriteLine("Saldo: " + GetSaldo());
            Console.WriteLine("==============================================================");
        }
    }
}
