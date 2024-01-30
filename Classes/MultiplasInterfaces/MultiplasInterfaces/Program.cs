using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Documento doc = new Documento() { Nome = "Artigo.docx" };
			Console.WriteLine("Arquivo:" + doc.Nome);
			doc.Ler();
			doc.Escrever();
			doc.Compactar();
			doc.Descompactar();
			Imagem img = new Imagem() { Nome = "Foto.jpg" };
			Console.WriteLine("Arquivo:" + img.Nome);
			img.Ler();
			img.Escrever();
			img.Compactar();
			img.Descompactar();
			Console.ReadLine();
		}
	}
}