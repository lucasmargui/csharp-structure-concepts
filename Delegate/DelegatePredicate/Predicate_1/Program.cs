using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Este Predicate retorna ture se o argumento é um
            //
            Predicate<int> EUm =  x => x == 1;
            //
            // Este Predicate retorna true se o argumento for maior que 5
            //
            Predicate<int> EmaiorQueCinco = (int x) => x >= 5;

            //
            // Teste das intancias de Predicate com parâmetros
            //
            Console.WriteLine(EUm.Invoke(1));
            Console.WriteLine(EUm.Invoke(2));
            Console.WriteLine(EmaiorQueCinco.Invoke(3));
            Console.WriteLine(EmaiorQueCinco.Invoke(10));
            Console.ReadKey();
        }
    }
}
