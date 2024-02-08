using System;
using BancoDoBrasil.Contas;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(TipoConta.ContaCorrente,"123456");
            conta.Depositar(500);
            conta.Sacar(300);
            Console.WriteLine(conta.getSaldo().ToString());
            Console.ReadLine();
        }
    }
}
