using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Rendimento { get; set; } = 0.6;
        public void Render()
        {
            double valorRendimento = Saldo * Rendimento;
            Saldo = Saldo + valorRendimento;
        }

        public override void Sacar(double valorSaque)
        {
            if (Saldo > valorSaque)
                base.Sacar(valorSaque);
            else
            {
                Console.WriteLine("Saldo insuficente para saque");
                MostrarSaldo();
            }
        }
    }
}
