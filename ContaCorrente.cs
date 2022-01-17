using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : ContaBancaria
    {
        public void Transferencia(double valor, ContaCorrente contaDestino)
        {
            contaDestino.Deposito(valor);
            Sacar(valor);
        }
    }
}
