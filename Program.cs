using Banco;

ContaCorrente c1 = new ContaCorrente();
ContaCorrente c2 = new ContaCorrente();
ContaPoupanca c3 = new ContaPoupanca();

c1.Saldo = 100;
c2.Saldo = 80;
c3.Saldo = 500;

c1.Transferencia(200, c2);