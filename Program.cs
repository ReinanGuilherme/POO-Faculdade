using POO_TransacoesBanco;



ContaCorrente contaReinan = new ContaCorrente("Reinan Guilherme", 120, 2, 1234, 3, "cesta 1", "10.2");
ContaPoupanca contaCPBruno = new ContaPoupanca("Bruno Reis", 120, 2, 1234, 3);

Console.WriteLine("Saldo inicial da Conta Corrente:");
contaReinan.Imprimir();

double valorDepositoCC = 100;
contaReinan.Depositar(valorDepositoCC);
Console.WriteLine($"Depósito de R${valorDepositoCC} realizado na Conta Corrente:");
contaReinan.Imprimir();

double valorSaqueCC = 20;
contaReinan.Sacar(valorSaqueCC);
Console.WriteLine($"Saque de R${valorSaqueCC} realizado na Conta Corrente:");
contaReinan.Imprimir();

Console.WriteLine("Saldo inicial da Conta Poupança:");
contaCPBruno.Imprimir();

double valorDepositoCP = 200;
contaCPBruno.Depositar(valorDepositoCP);
Console.WriteLine($"Depósito de R${valorDepositoCP} realizado na Conta Poupança:");
contaCPBruno.Imprimir();

double valorSaqueCP = 50;
contaCPBruno.Sacar(valorSaqueCP);
Console.WriteLine($"Saque de R${valorSaqueCP} realizado na Conta Poupança:");
contaCPBruno.Imprimir();

// Operação PIX
double valorPix = 30;
string nomeDestinatario = "Bruno";

Console.WriteLine("Realizando operação PIX na Conta Corrente:");
contaReinan.RealizarPix(valorPix, nomeDestinatario, contaCPBruno, contaCPBruno.GetChavePix());
contaReinan.Imprimir();

valorPix = 80;
nomeDestinatario = "Reinan";

Console.WriteLine("Realizando operação PIX na Conta Poupança:");
contaCPBruno.RealizarPix(valorPix, nomeDestinatario, contaReinan, contaReinan.GetChavePix());
contaCPBruno.Imprimir();

Console.ReadKey();