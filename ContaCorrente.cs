using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TransacoesBanco
{
    class ContaCorrente : ContaBancaria
    {
        private String cestaDescontos;
        private String chequeEspecial;

        //implementar depois
        //private String cartaoCredito;

        public ContaCorrente(
                                string Nome,
                                int Ag,
                                int DgAg,
                                int Conta,
                                int DgConta,
                                String cestaDescontos,
                                String chequeEspecial
                             ) : base(
                                        Nome,
                                        Ag,
                                        DgAg,
                                        Conta,
                                        DgConta
                                     )
        {
            this.cestaDescontos = cestaDescontos;
            this.chequeEspecial = chequeEspecial;
        }


        public override void Depositar(double valor)
        {
            if (CheckValor(valor))
            {
                SetSaldo(GetSaldo() + valor);
            }

        }

        public override void Sacar(double valor)
        {
            if (CheckValor(valor) && GetSaldo() >= valor)
            {
                SetSaldo(GetSaldo() - valor);
            }
        }

        public override void Transferir(ContaBancaria contaDestino, double valorTransferencia)
        {
            if (CheckValor(valorTransferencia) && GetSaldo() >= valorTransferencia)
            {
                SetSaldo(GetSaldo() - valorTransferencia);
                contaDestino.SetSaldo(contaDestino.GetSaldo() + valorTransferencia);
                Console.WriteLine("Transferência realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível realizar a transferência!");
            }
        }

        public override void RealizarPix(double valor, string nomeDestinatario, ContaBancaria contaDestino, string chavePix)
        {
            if (CheckValor(valor) && GetSaldo() >= valor)
            {
                SetSaldo(GetSaldo() - valor);
                contaDestino.Depositar(valor);
                Console.WriteLine($"PIX de R${valor} realizado para {nomeDestinatario} ({contaDestino.GetChavePix()})");
            }
            else
            {
                Console.WriteLine("Não foi possível realizar a operação PIX!");
            }
        }


    }
}
