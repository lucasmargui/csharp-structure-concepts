using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
	public class Pessoa
	{
		public string Nome;
	}
	public class PessoaFisica : Pessoa
	{
		public string CPF;
	}
	public class PessoaJuridica : Pessoa
	{
		public string CNPJ;
	}
	public class Governo : Pessoa
	{
		public string Departamento;
	}
}