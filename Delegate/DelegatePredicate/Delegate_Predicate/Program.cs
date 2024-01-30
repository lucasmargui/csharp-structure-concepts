using System;

namespace Delegate_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um array de numeros inteiros
            int[] numeros = { 2343, 5349, 6039, 4326, 3038, 1987, 8762, 1098 };

            // Define o delegato Predicate<T>
            //Predicate<int> predicate = EncontraNumeros;

            // Encontra o numero que é maior que 7000
            int numero = Array.Find(numeros, n => n > 7000);

            // exibe o primeiro numero encontrado que atente o criterio
            Console.WriteLine("Encontrado: n = {0} ", numero);
            Console.ReadKey();
        }
        ////função que retorna true (n1>7000) / false (n1<=7000) 
        //private static bool EncontraNumeros(int n1)
        //{
        //    return n1 > 7000;
        //}
    }
}
