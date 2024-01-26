using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public abstract class Animal
    {
        public abstract string Sound { get; }

        // Essas assinaturas especificam os parâmetros e o valor retornado, mas não têm nenhuma implementação (corpo do método)
        public virtual void Move()
        {
            Console.WriteLine("Moving...");
        }
    }
}
