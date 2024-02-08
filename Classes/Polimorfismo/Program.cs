using System;

namespace Pedidos
{
	class Program
	{
		static void Main(string[] args)
		{
			Pedido pedido = new Pedido(new Cartao()); // injeto a dependência
			double valor = 2000;
			pedido.Pagar(valor);



			var valor2 = 2500;
			// Injeção de dependência (DI) / Inversão de Controle (IoC)
			var pedido2 = new Pedido(new Cheque());
			pedido2.Pagar(valor);
			Console.ReadLine();
		}
	}
}
