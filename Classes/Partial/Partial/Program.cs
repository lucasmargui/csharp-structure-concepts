using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace ClassesParciais
{

    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario(123, "guinther", "senha");
            if (user.Autenticar())
                Console.WriteLine("Usuário autenticado com sucesso");
            else
                Console.WriteLine("Credenciais inválidas");
            Console.ReadLine();
        }
    }
}