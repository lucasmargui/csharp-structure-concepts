using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace From_Select_Anonimo
{
	class Program
	{
		static void Main(string[] args)
		{

			//Exemplo 1

			// Specify the data source.
			int[] scores = { 97, 92, 81, 60 };

			// Define the query expression.
			IEnumerable<int> scoreQuery =
				from score in scores
				where score > 80
				select score;

			// Execute the query.
			foreach (int i in scoreQuery)
			{
				Console.Write(i + " ");
			}

			// Output: 97 92 81

			//Exemplo 2

			var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
						select new // tipo anônimo
						{
							NomeArquivo = Path.GetFileName(arquivo),
							Extensao = Path.GetExtension(arquivo)
						};


		}
	}
}
