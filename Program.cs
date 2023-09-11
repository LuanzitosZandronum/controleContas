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

Cliente cliente1 = new Cliente("12345678910", "José", 1990);
Banco banco1 = new Banco(10, "Budega");
Agencia agencia1 = new Agencia(10, "170365-1", "32325657", banco1);
Conta conta1 = new Conta(1, 1000m, cliente1, agencia1);



Cliente cliente2 = new Cliente("10987654321", "João", 1980);
Banco banco2 = new Banco(20, "Santana");
Agencia agencia2 = new Agencia(20, "169242004", "265739", banco2);
Conta conta2 = new Conta(2, 500m, cliente2, agencia2);




/*
string nomeTitular1 = conta1.Titular.Nome;
string nomeTitular2 = conta2.Titular.Nome;
*/
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

Console.WriteLine($"Número da Conta: {conta1.Numero} com saldo {conta1.Saldo}. Titular: {conta1.Titular.Nome}");
Console.WriteLine($"Número da Conta: {conta2.Numero} com saldo {conta2.Saldo}. Titular: {conta2.Titular.Nome}");
Console.WriteLine($"A conta com o maior saldo é a conta {maior}");

//Testes com Agência e Banco da Conta Número 1
Console.WriteLine($"{cliente1.Nome} = CPF: {cliente1.Cpf}, Nascimento: {cliente1.anoNascimento}, {conta1.AgenciaReferente.Numero}");
Console.WriteLine($"CEP da Agência: {conta1.AgenciaReferente.Cep}, Nome do Banco:{conta1.AgenciaReferente.BancoReferente.Nome}, Número do Banco: {conta1.AgenciaReferente.BancoReferente.Numero}");


Console.WriteLine($"{cliente2.Nome} = {cliente2.Cpf}");
Console.ReadLine();
