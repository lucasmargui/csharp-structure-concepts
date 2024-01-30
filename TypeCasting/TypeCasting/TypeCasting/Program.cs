using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
	public static class RelatorioPessoas
	{
		public static void Imprimir(Pessoa pessoa)
		{
			Console.WriteLine(pessoa.Nome);
			if (pessoa is PessoaJuridica)
				Console.WriteLine((pessoa as PessoaJuridica).CNPJ);
			if (pessoa is PessoaFisica)
				Console.WriteLine((pessoa as PessoaFisica).CPF);
			if (pessoa is Governo)
				Console.WriteLine((pessoa as Governo).Departamento);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var pf = new PessoaFisica();
			pf.Nome = "Guinther";
			pf.CPF = "123";
			var pj = new PessoaJuridica();
			pj.Nome = "GPauli";
			pj.CNPJ = "1234";
			var g = new Governo();
			g.Nome = "Departamento de Justiça";
			g.Departamento = "Justiça";
			RelatorioPessoas.Imprimir(pj);
			RelatorioPessoas.Imprimir(pf);
			RelatorioPessoas.Imprimir(g);
		}
	}
}