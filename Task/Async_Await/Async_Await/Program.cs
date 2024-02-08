using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
	class Program
	{
		public static Task<IEnumerable<int>> getNumerosPrimos(int min, int count)
		{
			return Task.Run(() => Enumerable.Range(min, count).
				Where(num => Enumerable.Range(2, (int)Math.Sqrt(num) - 1).
				All(i => num % i > 0)));
		}


		private static async void ImprimirNumerosPrimos()
		{
			for (int i = 0; i < 10; i++)
			{
				var resultado = await getNumerosPrimos(i * 100000 + 1, i * 1000000);
				resultado.ToList().ForEach(x => Console.WriteLine(x));
			}
		}

		void DoIndependentWork()
		{
			Console.WriteLine("Working...");
		}

		public async Task<int> GetUrlContentLengthAsync()
		{
			var client = new HttpClient();

			Task<string> getStringTask =
				client.GetStringAsync("https://learn.microsoft.com/dotnet");

			DoIndependentWork();

			string contents = await getStringTask;

			return contents.Length;
		}

		static void Main(string[] args)
		{
			//Exemplo 1
			ImprimirNumerosPrimos();
			Console.ReadLine();

		}

	}
}