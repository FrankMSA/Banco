using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class ContaBancaria
    {
        public string NomeDono { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public virtual void Sacar(double valorSaque)
        {
            double novoSaldo = Saldo - valorSaque;
            Saldo = novoSaldo;
            MostrarSaldo();
        }

        public void Deposito(double valorDeposito)
        {
            double novoSaldo = Saldo + valorDeposito;
            Saldo = novoSaldo;
            MostrarSaldo();
        }

        public void MostrarSaldo()
        {
            Console.WriteLine("Saldo atual é R$" + Saldo);
        }
    }
}
