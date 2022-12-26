using byteBank.Contas;
using byteBank.Titular;
using System.Security.Cryptography.X509Certificates;


Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "00510972306";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-x";
conta.numero_agencia = 15;
conta.saldo = 100;

Console.WriteLine("titular = " + conta.titular.nome);
Console.WriteLine();
Console.WriteLine("cpf = " + conta.titular.cpf);
Console.WriteLine();
Console.WriteLine( "Profissão" + conta.titular.profissao);
Console.WriteLine();
Console.WriteLine( "N° da conta = " + conta.conta);
Console.WriteLine();
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine();
Console.WriteLine("N° da Agência = " + conta.numero_agencia);


//ContaCorrente ContaDoAndre = new ContaCorrente();
//ContaDoAndre.titula = "Andre Silva";
//ContaDoAndre.numero_agencia = 15;
//ContaDoAndre.conta = "1010-X";
//ContaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da Conta do Andre = " + ContaDoAndre.saldo);

//ContaCorrente ContaDaMaria = new ContaCorrente();
//ContaDaMaria.titula = "Maria Sousa";
//ContaDaMaria.numero_agencia = 17;
//ContaDaMaria.conta = "1010-5";
//ContaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da Conta da Maria = " + ContaDaMaria.saldo);

//ContaDoAndre.Transferir(50, ContaDaMaria);

//Console.WriteLine("Saldo do Andre " +ContaDoAndre.saldo);
//Console.WriteLine("SAldo da Maria" + ContaDaMaria.saldo);
//ContaCorrente ContaDoPedro = new ContaCorrente();
//ContaDoPedro.titula = "Pedro Silva";

