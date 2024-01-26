using System;
using System.Collections.Generic;
using System.Text;

namespace Partial
{

    //Separar a definição de eventos

    public partial class MinhaClasse
    {
        public event EventHandler MeuEvento;
        private void RaiseMeuEvento()
        {
            MeuEvento?.Invoke(this, EventArgs.Empty);
        }
    }
    public partial class MinhaClasse
    {
        public void FazAlgo()
        {
            // faz algo aqui
            RaiseMeuEvento();
        }
    }
}
