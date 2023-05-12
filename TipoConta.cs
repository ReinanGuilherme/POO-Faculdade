using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TransacoesBanco
{
    public enum TipoConta
    {
        [Description("CC")]
        ContaCorrente,

        [Description("CP")]
        ContaPoupanca
    }
}
