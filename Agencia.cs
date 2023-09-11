using System;

public class Agencia
{
	public Agencia(int numero, string cep, string telefoneContato, Banco banco)
	{
		Numero = numero;
		Cep = cep;
		TelefoneContato = telefoneContato;
		BancoReferente = banco;
	}
	public int Numero { get; set; }
	public string Cep { get; set; }
	public string TelefoneContato { get; set; }
	public Banco BancoReferente { get; set; }
	
}
