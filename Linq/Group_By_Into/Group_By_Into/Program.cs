using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Group_By_Into
{
	class Program
	{
		static void Main(string[] args)
		{
			var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
						let infoArquivo = new FileInfo(arquivo)
						group infoArquivo by infoArquivo.Extension.ToUpper() into g
						let extensao = g.Key
						orderby extensao
						select new
						{
							Extensao = extensao,
							NumeroArquivos = g.Count(),
							TamanhoTotalAquivosKB = g.Sum(fi => fi.Length) / 1024M,
							TamanhoMedioAquivosKB = g.Average(fi => fi.Length) / 1024D,
							TamanhoMenorquivosKB = g.Min(fi => fi.Length) / 1024M,
							TamanhoMaiorAquivosKB = g.Max(fi => fi.Length) / 1024M
						};
		}
	}
}
