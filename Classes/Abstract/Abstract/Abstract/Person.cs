using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public class Person
    {
        protected string ssn = "444-55-6666";
        protected string name = "John L. Malgraine";

        // Essas assinaturas especificam os parâmetros e o valor retornado, mas não têm nenhuma implementação (corpo do método)
        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
        }
    }
}
