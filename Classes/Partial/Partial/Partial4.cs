using System;
using System.Collections.Generic;
using System.Text;

namespace Partial
{
    //Separar a definição de propriedades
    public partial class MinhaClasse
    {
        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
    }
    public partial class MinhaClasse
    {
        public string Nome { get; set; }
    }
}
