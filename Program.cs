using POO_TransacoesBanco;



ContaBancaria pessoa1 = new ContaBancaria("Reinan O Lindo", "111.111.111-43", TipoConta.ContaCorrente);

ContaBancaria pessoa2 = new ContaBancaria("Pessoa não importante", "222.222.222-86", TipoConta.ContaCorrente);

pessoa1.Depositar(1000);
pessoa2.Depositar(500);

Console.WriteLine("Saldo da Pessoa 1: " + pessoa1.Saldo);
Console.WriteLine("Saldo da Pessoa 2: " + pessoa2.Saldo);

pessoa1.Transferir(500, pessoa2);

Console.WriteLine("Saldo da Pessoa 1 após transferência: " + pessoa1.Saldo);
Console.WriteLine("Saldo da Pessoa 2 após transferência: " + pessoa2.Saldo);

pessoa2.Sacar(200);

Console.WriteLine("Saldo da Pessoa 2 após saque: " + pessoa2.Saldo);
Console.WriteLine("------------RESUMO------------");
Console.WriteLine("Saldo da Pessoa 1: " + pessoa1.Saldo);
Console.WriteLine("Saldo da Pessoa 2: " + pessoa2.Saldo);

Console.ReadLine();