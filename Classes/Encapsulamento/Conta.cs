using System;

namespace BancoDoBrasil.Contas
{
    public enum TipoConta { ContaCorrente, ContaPoupanca };

    public class Conta
    {
        // atributos
        public string Num;
        private double _saldo; // encapsulamento
        public TipoConta Tipo;
        // construtor
        public Conta(TipoConta tipo, string num)
        {
            this.Num = num;
            this.Tipo = tipo;
            this._saldo = 0;
        }
        // métodos
        public void Sacar(double valor)
        {
            _saldo = _saldo - valor;
        }
        public void Depositar(double valor)
        {
            _saldo = _saldo + valor;
        }
        public double getSaldo()
        {
            return _saldo; // somente-leitura
        }
    }
}
