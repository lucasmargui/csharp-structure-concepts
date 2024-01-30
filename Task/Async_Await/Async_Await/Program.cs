using System;
using System.Collections.Generic;
using System.Linq;
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



		static void Main(string[] args)
		{
			ImprimirNumerosPrimos();
			Console.ReadLine();

		}

	}
}