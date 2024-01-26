using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;
        //// padrão
        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }
        //// Overload de parametros

        public Cliente(int codigo)
        {
            this.Codigo = codigo;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }

        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Contato = new Contato();
        }


        //// nova implementação de um membro herdado
        public override string ToString()
        {
            return "Codigo: " + Codigo + ", Nome: " + Nome;
        }
    }

    //// chamando construtor da classe base
    public class ClienteVIP : Cliente
    {
        public int Tempo;
        public ClienteVIP(int codigo, string nome)
            : base(codigo, nome)
        {
            this.Tempo = 10;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Codigo = 123;
            cli1.Nome = "Guinther";
            cli1.Contato.Tipo = "Telefone";
            cli1.Contato.Descricao = "99999999";

            Cliente cli2 = new Cliente(456);
            cli2.Nome = "Rudolfo";

            Cliente cli3 = new Cliente(789, "Fulano");

            Cliente cli4 = new ClienteVIP(123, "Beltrano");

            Console.WriteLine(cli1);
            Console.WriteLine(cli2);
            Console.WriteLine(cli3);
            Console.WriteLine(cli4);


            Console.ReadLine();
        }
    }
}