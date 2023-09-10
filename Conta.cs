using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero, decimal saldoInicial, Cliente titular)
        {
            if (titular == null)
            {
                throw new ArgumentNullException(nameof(titular), "Deve haver um titular.");
            }
            if (saldoInicial < 10.0m)
            {
                throw new ArgumentException("O saldo inicial deve ser superior a R$10,00.");
            }
            Numero = numero;
            Saldo = saldoInicial;
            Titular = titular;
        }

        public Conta() { }

        public long Numero { get; private set; }
        public decimal Saldo { get; set; }
        public Cliente? Titular { get; set; }

        public void deposito(decimal valor)
        {
            if (valor > 0)
                Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (valor > 0)
            {
                if (Saldo - valor - 0.10m >= 0)
                {
                    Saldo -= (valor + 0.10m);
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para o saque.");
                }
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser maior do que zero");
            }
        }
        public void Transferencia(Conta destino, decimal valor)
        {
            if (valor > 0)
            {
                // Verifique se há saldo suficiente na conta de origem.
                if (Saldo >= valor)
                {
                    Saque(valor); // Realiza o saque da conta de origem.
                    destino.deposito(valor); // Realiza o depósito na conta de destino.
                    Console.WriteLine($"Transferência de R${valor} realizada com sucesso.");
                    Console.WriteLine($"Saldo da conta {Numero}: R${Saldo}");
                    Console.WriteLine($"Saldo da conta {destino.Numero}: R${destino.Saldo}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar a transferência.");
                }
            }
            else
            {
                Console.WriteLine("O valor da transferência deve ser maior que zero.");
            }
        }



    }
}
