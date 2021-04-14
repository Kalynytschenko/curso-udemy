using System;

namespace Encapsulameto_construtores_modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool depIni = false;
            char depInicial;
            int valor = 0;

            ContaBancaria contaBancaria = new ContaBancaria();

            Console.WriteLine("Entre com o numero da conta:");
            contaBancaria.NumConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Titularrr da conta:");
            contaBancaria.Titular = Console.ReadLine();
            Console.WriteLine("Havera deposito inicial (s/n)?");
            depInicial = char.Parse((Console.ReadLine()));

            if (depInicial == 'S' || depInicial == 's')
            {
                Console.WriteLine("Entre com o valor de deposito inincial:");
                valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados da Conta:\nConta " + contaBancaria.NumConta + ", Titular: " + contaBancaria.Titular + ", Saldo: $" + contaBancaria.Deposito(valor));

                Console.WriteLine("Entre com o valor de deposito:");
                valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados da Conta atualizados:\nConta " + contaBancaria.NumConta + ", Titular: " + contaBancaria.Titular + ", Saldo: $" + contaBancaria.Deposito(valor));

                Console.WriteLine("Entre com o valor para saque:");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Dados da Conta atualizados:\nConta " + contaBancaria.NumConta + ", Titular: " + contaBancaria.Titular + ", Saldo: $" + contaBancaria.Saque(valor));
            }
            else
            {
                Console.WriteLine("Dados da Conta:\nConta " + contaBancaria.NumConta + ", Titular: " + contaBancaria.Titular + ", Saldo: $" + contaBancaria.Deposito(valor));

                Console.WriteLine("Entre com o valor de deposito:");
                valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados da Conta atualizados:\nConta " + contaBancaria.NumConta + ", Titular: " + contaBancaria.Titular + ", Saldo: $" + contaBancaria.Deposito(valor));

                Console.WriteLine("Entre com o valor para saque:");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Dados da Conta atualizados:\nConta " + contaBancaria.NumConta + ", Titular: " + contaBancaria.Titular + ", Saldo: $" + contaBancaria.Saque(valor));
            }







        }
    }
}
