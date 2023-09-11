using System;

public class Banco
{
	public Banco(int numero, string nome)
	{
		Nome = nome;
		Numero = numero;
	}
    public Banco() 
	{ 
		Nome = string.Empty;
		Numero = 0;
	}
    public string Nome { get; set; }
	public int Numero { get; set; }
}
