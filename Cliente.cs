using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
	public class Cliente
	{
		public Cliente(long cpf, string nome, int anonascimento)
		{
			if (2023 - anonascimento < 18)
			{
				throw new ArgumentException("Não deve ser menor de idade");
			}
			Cpf = cpf;
			Nome = nome;
			anoNascimento = anonascimento;
		}
		public Cliente() { }
		public long Cpf { get; set; }
		public string Nome { get; set; }
		public int anoNascimento { get; set; }
	}
}
