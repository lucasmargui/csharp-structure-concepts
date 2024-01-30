using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Group_Composto
{
	class Program
	{

		private static string[] obterTodosArquivosDotNet4()
		{
			return
			  Directory.GetFiles(
				@"C:\Windows\Microsoft.NET\Framework\v4.0.30319",
				"*",
				SearchOption.AllDirectories
			  );
		}
		static void Main(string[] args)
		{
			var query = from arquivo in obterTodosArquivosDotNet4()
						let infoArquivo = new FileInfo(arquivo)
						group infoArquivo by new
						{
							Pasta = infoArquivo.DirectoryName,
							Extensao = infoArquivo.Extension.ToUpper()
						}
					into infoArquivosPorPastaExtensao
						let tamanhoKB = infoArquivosPorPastaExtensao.Sum(ia => ia.Length) / 1024M
						orderby infoArquivosPorPastaExtensao.Key.Pasta,
						  tamanhoKB descending
						select new
						{
							infoArquivosPorPastaExtensao.Key.Pasta,
							infoArquivosPorPastaExtensao.Key.Extensao,
							NumeroArquivos = infoArquivosPorPastaExtensao.Count(),
							tamanhoKB = tamanhoKB
						};
		}
	}
}
