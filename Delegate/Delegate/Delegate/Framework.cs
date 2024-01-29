/*
Sobre o autor:
Guinther Pauli
Cursos Treinamentos Consultoria
Delphi Certified Professional - 3,5,6,7,2005,2006,Delphi Web,Kylix,XE
Microsoft Certified Professional - MCP,MCAD,MCSD.NET,MCTS,MCPD (C#, ASP.NET, Arquitetura)
Colaborador Editorial Revistas .net Magazine e ClubeDelphi
MVP (Most Valuable Professional)
Emails: guintherpauli@gmail.com / guinther@gpauli.com
http://www.gpauli.com
http://www.guintherpauli.blogspot.com.br
http://www.facebook.com/guintherpauli
http://www.twitter.com/guintherpauli
http://br.linkedin.com/in/guintherpauli
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore;


namespace Delegate
{

    delegate void NotifyCallback(string str);
    public delegate void SimplesDelegate();




    public class Boleto
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Boleto pago no valor de " + valor);
        }
    }
    public class Pedido
    {
        private Boleto _boleto = new Boleto();

        public void Fechar(double valor)
        {
            // delegação...
            this._boleto.Pagar(valor);
        }
    }




    //Nome do tipo do meu delegate
    public delegate void PagarEvent(double valor);

    public class Pedido2
    {
        public event PagarEvent Pagar;

        public void Fechar(double valor)
        {
            // delegação...
            //Chamo o evento pagar que vai apontar para um determinado método, e esse método vai ser injetado de fora
            this.Pagar(valor);
        }
    }



    //Exemplo 4
    // Class to total and average prices of books:
    class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;

        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }

        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }
    }




}