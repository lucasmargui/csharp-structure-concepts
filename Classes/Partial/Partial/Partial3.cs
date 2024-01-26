using System;
using System.Collections.Generic;
using System.Text;

//Separar a implementação de uma interface

namespace Partial
{

    using Interface1;
    public partial class MinhaClasse : IMinhaInterface
    {
        public void Metodo1()
        {
            Console.WriteLine("Método1");
        }
    }

    public partial class MinhaClasse
    {
        public void Metodo2()
        {
            Console.WriteLine("Método2");
        }
    }
}
