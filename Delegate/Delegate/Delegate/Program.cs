using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1
            var pedido = new Pedido();
            pedido.Fechar(2000);
            Console.ReadLine();



            //Exemplo 2
            var pedido2 = new Pedido2();
            //To apontando o evento Pagar para a função pedido_Pagar ou seja, estou injetando código
            //Poderia ter um multcast
            pedido2.Pagar += pedido_Pagar;

            //Fechar aciona o evento Pagar que recebe um tipo delegate PagarEvent, e oque o evento Pagar vai fazer foi passado na linha


            ////Caminho

            //chamando evento        delegaçao (pedido.Pagar += pedido_Pagar)          evento delegado     
            //pedido.Fechar(2000) =>             this.Pagar(2000)               =>     pedido_Pagar(2000)
            
            pedido2.Fechar(2000);
            Console.ReadLine();
        }

        static void pedido_Pagar(double valor)
        {
            Console.WriteLine("Pago boleto no valor de " + valor);
        }
    }
    }
}