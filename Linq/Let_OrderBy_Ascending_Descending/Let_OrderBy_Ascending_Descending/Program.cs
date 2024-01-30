using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Let_OrderBy_Ascending_Descending
{
	class Program
	{
		static void Main(string[] args)
		{
			var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
						let nomeArquivo = Path.GetFileName(arquivo)
						let extensao = Path.GetExtension(arquivo).ToUpper()
						orderby extensao, nomeArquivo descending
						select new
						{
							Arquivo = nomeArquivo,
							Extensao = extensao
						};
		}
	}
}
