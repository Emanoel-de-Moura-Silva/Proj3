using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proj3
{
    public class ContaBancaria
    {
        public int Numero { get; set; }     //propriedades da classe
        public decimal Saldo { get; set; }

        public ContaBancaria()
        { //construtor default
        }

        //construtor parametrizado
        public ContaBancaria(int Numero, decimal Saldo)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
        }

        public void debitar(decimal vlr)
        { //método debitar
            if (Saldo >= vlr)
                Saldo = Saldo - vlr;
            else
                throw new InvalidOperationException("movimentação superior ao saldo");
        }

        public void creditar(decimal vlr)
        { //método creditar
            Saldo = Saldo + vlr;
        }
        

    }
}