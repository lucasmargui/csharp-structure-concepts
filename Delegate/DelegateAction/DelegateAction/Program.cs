using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAction
{
	public class Cliente
	{
		public int ID { get; set; }
		public string Nome { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{

			//Exemplo 1

			//Action<Cliente> mostrarAction = new Action<Cliente>(Mostrar);
			Action<Cliente> mostrarAction = new Action<Cliente>(c => Console.WriteLine(c.Nome));
			var gp = new Cliente() { ID = 1, Nome = "Guinther Pauli" };
			var rp = new Cliente() { ID = 2, Nome = "Rudolfo Pauli" };
			var ms = new Cliente() { ID = 3, Nome = "Michael Scofield" };
			var jp = new Cliente() { ID = 4, Nome = "John Petrucci" };
			List<Cliente> Clientes = new List<Cliente>();
			Clientes.Add(gp);
			Clientes.Add(rp);
			Clientes.Add(ms);
			Clientes.Add(jp);
			Clientes.ForEach(mostrarAction);
			//foreach (var c in Clientes)
			//    Console.WriteLine(c.Nome);
			Console.ReadLine();




		}

		//public static void Mostrar(Cliente c)
		//{
		//    Console.WriteLine(c.Nome);
		//}
	}
}