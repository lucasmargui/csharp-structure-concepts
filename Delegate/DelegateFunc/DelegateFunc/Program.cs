
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunc
{
	public class Produto
	{
		public int Id;
		public string Nome;
		public double Preco;
		public override string ToString()
		{
			return Id + "-" + Nome + "-" + Preco;
		}

	}


	class Program
	{
		private static string BomDia()
		{
			return "Bom dia";
		}

		private static double Adicionar(double n1, double n2)
		{
			return n1 + n2;
		}


		static void Main(string[] args)
		{

			//Exemplo 1
			//Func<Produto, Produto> func = new Func<Produto, Produto>(Teste);
			Func<Produto, bool> func = new Func<Produto, bool>(p => p.Preco >= 2000);
			List<Produto> prods = new List<Produto>()
			{
				new Produto() { Id = 1, Nome = "iPad", Preco = 2450.50 },
				new Produto() { Id = 2, Nome = "iPhone", Preco = 1500.00},
				new Produto() { Id = 3, Nome = "Google Glass", Preco = 2000.00},
				new Produto() { Id = 4, Nome = "Dream Theater DVD", Preco = 100}
			};
			foreach (var p in prods.Where(func))
				Console.WriteLine(p);
			//foreach (Produto p in prods)
			//    if (Teste(p) != null)
			//        Console.WriteLine(p.Nome);





			//Exemplo 2 ---> Usando 1 parâmetro :

			Func<string> saudacoes = BomDia;
			string bomdia = saudacoes();
			Console.WriteLine(bomdia);



			//Exemplo 3 ---> Usando 2 parâmetros :
			Func<double, double, double> Calcular = Adicionar;
			double resultadoSoma = Calcular(9.7, 12.6);
			Console.WriteLine(resultadoSoma);
			Console.ReadKey();



			//Exemplo 4 : Usando Métodos Anônimos

			Func<int, bool> IsPositivo = delegate (int numero)
			{
				return numero > 0;
			};
			Console.WriteLine(string.Format("O Numero 9 é positivo : {0} ", IsPositivo(9)));
			Console.ReadKey();



			//Exemplo 5 Usando Expressões Lambdas


			Func<int, bool> IsPositivo2 = numero => numero > 0;
			Console.WriteLine(string.Format("O Numero 9 é positivo : {0} ", IsPositivo2(9)));
			Console.ReadKey();


		}




	}
}