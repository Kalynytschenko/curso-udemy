using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulameto_construtores_modificadores
{
    class ContaBancaria
    {
        public int NumConta { get; private set; }

        public string Titular { get; set; }

        public int Saldo { get; set; }


        public int Deposito(int valor)
        {
            Saldo = Saldo + valor;
            return Saldo;
        }

        public int Saque(int valor)
        {
            Saldo = Saldo - valor -5;
            return Saldo;
        }


    }
}
