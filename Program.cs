// See https://aka.ms/new-console-template for more information
using controleContas;

/* atribuição de atributos antiga lol
 
Conta conta2 = new Conta(654321);
Cliente cliente2 = new Cliente(12345678900);
cliente2.Nome = "João";
conta2.Saldo = 11m;
conta2.Titular = cliente2;

Conta conta1 = new Conta(123456);
Cliente cliente1 = new Cliente(12345678901);
cliente1.Nome = "José";
conta1.Saldo = conta2.Saldo * 0.7m;
conta1.Titular = cliente1;
*/

Cliente cliente1 = new Cliente(123456, "José", 1990);
Conta conta1 = new Conta(1, 1000m, cliente1);

Cliente cliente2 = new Cliente(654321, "João", 1980);
Conta conta2 = new Conta(2, 500m, cliente2);

string nomeTitular1 = conta1.Titular.Nome;
string nomeTitular2 = conta2.Titular.Nome;

//conta1.Saque(50m);  CHAMANDO FUNÇÃO DE SAQUE
//conta1.Transferencia(conta2, 100m);   CHAMANDO FUNÇÃO DE TRANSFERÊNCIA

float maior, menor;

if (conta1.Saldo > conta2.Saldo)
{
    maior = Convert.ToSingle(conta1.Numero);
    menor = Convert.ToSingle(conta2.Numero);
}
else 
{
    maior = Convert.ToSingle(conta2.Numero);
    menor = Convert.ToSingle(conta1.Numero);
}

//conta1.Numero = 123456;

Console.WriteLine($"Número da Conta: {conta1.Numero} com saldo {conta1.Saldo}. Titular: {nomeTitular1}");
Console.WriteLine($"Número da Conta: {conta2.Numero} com saldo {conta2.Saldo}. Titular: {nomeTitular2}");
Console.WriteLine($"A conta com o maior saldo é a conta {maior}");
Console.WriteLine($"{cliente1.Nome} = {cliente1.Cpf}");
Console.WriteLine($"{cliente2.Nome} = {cliente2.Cpf}");
Console.ReadLine();