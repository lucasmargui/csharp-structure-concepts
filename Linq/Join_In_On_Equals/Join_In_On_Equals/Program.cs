using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Join_In_On_Equals
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
			string[] arquivosDotNet4 = obterTodosArquivosDotNet4();

			var tamanhoTotaisPorPasta = from arquivo in arquivosDotNet4
										let infoArquivo = new FileInfo(arquivo)
										group infoArquivo by infoArquivo.DirectoryName into g
										select new
										{
											Pasta = g.Key,
											TamanhoTotalKB = g.Sum(ia => ia.Length) / 1024M
										};

			var query = from arquivo in arquivosDotNet4
						let infoArquivo = new FileInfo(arquivo)
						group infoArquivo by new
						{
							Pasta = infoArquivo.DirectoryName,
							Extensao = infoArquivo.Extension.ToUpper()
						}
						  into infoArquivosPorPastaExtensao
						join tamanhoTotalPorPasta in tamanhoTotaisPorPasta // consulta anterior
						on infoArquivosPorPastaExtensao.Key.Pasta
						equals tamanhoTotalPorPasta.Pasta
						into juncaoComTamanhoTotalKB
						let tamanhoTotalKB = juncaoComTamanhoTotalKB.Single().TamanhoTotalKB
						let tamanhoKB = infoArquivosPorPastaExtensao.Sum(ia => ia.Length) / 1024M
						orderby infoArquivosPorPastaExtensao.Key.Pasta,
						  tamanhoKB descending
						select new
						{
							infoArquivosPorPastaExtensao.Key.Pasta,
							infoArquivosPorPastaExtensao.Key.Extensao,
							NumeroArquivos = infoArquivosPorPastaExtensao.Count(),
							TamanhoKB = tamanhoKB,
							Porcentagem = 100 * (tamanhoKB / tamanhoTotalKB)
						};
		}
	}
}
