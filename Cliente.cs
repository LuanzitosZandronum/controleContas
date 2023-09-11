using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
	public class Cliente
	{
		public Cliente(string cpf, string nome, int anonascimento)
		{
			if (string.IsNullOrWhiteSpace(nome))
			{
				throw new ArgumentException("O nome do cliente não deve estar em branco.");
			}
			if (cpf == null)
			{
				throw new ArgumentException("O CPF do cliente deve ser informado.");
			}
			if (!ValidCPF(cpf)) 
			{
				throw new ArgumentException("O CPF do cliente deve conter exatamente 11 dígitos.");
			}
			if (DateTime.Now.Year - anonascimento < 18)
			{
				throw new ArgumentException("Não deve ser menor de idade.");
			}
			Cpf = cpf;
			Nome = nome;
			anoNascimento = anonascimento;
		}
		public Cliente() 
		{ 
			Cpf = string.Empty;
			Nome = string.Empty;
			anoNascimento = 0;
		}

		public string Cpf { get; set; }
		public string Nome { get; set; }
		public int anoNascimento { get; set; }

		private static bool ValidCPF(string cpf)
		{
			string cpfStr = cpf.ToString().PadLeft(11, '0');

			if (cpfStr.Length != 11 )
			{
				return false;
			}
			return true;
		}
	}
}
