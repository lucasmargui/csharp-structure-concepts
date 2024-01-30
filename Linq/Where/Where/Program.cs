using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Where
{
	class Program
	{
		static void Main(string[] args)
		{
			var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
						let infoArquivo = new FileInfo(arquivo)
						let tamanhoArquivoMB = infoArquivo.Length / 1024M / 1024M
						where tamanhoArquivoMB > 1M &&
						  infoArquivo.Extension.ToUpper() == ".EXE"
						orderby tamanhoArquivoMB
						select new
						{
							Nome = infoArquivo.Name,
							TamanhoMB = tamanhoArquivoMB
						};
		}
	}
}
