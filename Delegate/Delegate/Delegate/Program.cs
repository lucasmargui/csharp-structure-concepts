using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore;

namespace Delegate
{

	class Program
	{




		// Declare a method with the same signature as the delegate
		static void Notify(string name)
		{
			Console.WriteLine($"Notification received for: {name}");
		}

		public static void minhaFuncao()
		{
			Console.WriteLine("Eu fui chamada por um delegate ...");
		}

		static void pedido_Pagar(double valor)
		{
			Console.WriteLine("Pago boleto no valor de " + valor);
		}


		// Print the title of the book.
		static void PrintTitle(Book b)
		{
			Console.WriteLine($"   {b.Title}");
		}

		// Initialize the book database with some test books:
		static void AddBooks(BookDB bookDB)
		{
			bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
			bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
			bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
			bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
		}




		static void Main(string[] args)
		{


			//Exemplo 1 : Declarar um tipo de delegado e declarar um método com uma assinatura correspondente:

			// Create an instance of the delegate.
			NotifyCallback del1 = new NotifyCallback(Notify);


			//Exemplo 1.2 : Atribuir um grupo de métodos a um tipo de delegado:
			//provides a simpler way to declare an instance of NotifyCallback.

			NotifyCallback del2 = Notify;


			//Exemplo 1.3 : Declarar um método anônimo:
			// Instantiate NotifyCallback by using an anonymous method.

			NotifyCallback del3 = delegate (string name)
			{ Console.WriteLine($"Notification received for: {name}"); };


			//Exemplo 1.4 : 
			// Instantiate NotifyCallback by using a lambda expression.
			NotifyCallback del4 = name => { Console.WriteLine($"Notification received for: {name}"); };


			//Exemplo 2 :
			var pedido = new Pedido();
			pedido.Fechar(2000);


			//Exemplo 3 :
			var pedido2 = new Pedido2();
			//To apontando o evento Pagar para a função pedido_Pagar ou seja, estou injetando código
			//Poderia ter um multcast
			pedido2.Pagar += pedido_Pagar;

			//Fechar aciona o evento Pagar que recebe um tipo delegate PagarEvent, e oque o evento Pagar vai fazer foi passado na linha


			////Caminho

			//chamando evento        delegaçao (pedido.Pagar += pedido_Pagar)          evento delegado     
			//pedido.Fechar(2000) =>             this.Pagar(2000)               =>     pedido_Pagar(2000)

			pedido2.Fechar(2000);



			//Exemplo 4 : Bookstore
			BookDB bookDB = new BookDB();

			// Initialize the database with some books:
			AddBooks(bookDB);

			// Print all the titles of paperbacks:
			Console.WriteLine("Paperback Book Titles:");

			// Create a new delegate object associated with the static
			// method Test.PrintTitle:
			bookDB.ProcessPaperbackBooks(PrintTitle);

			// Get the average price of a paperback by using
			// a PriceTotaller object:
			PriceTotaller totaller = new PriceTotaller();

			// Create a new delegate object associated with the nonstatic
			// method AddBookToTotal on the object totaller:
			bookDB.ProcessPaperbackBooks(totaller.AddBookToTotal);

			Console.WriteLine("Average Paperback Book Price: ${0:#.##}",
					totaller.AveragePrice());



			Console.ReadLine();



		}


	}

}