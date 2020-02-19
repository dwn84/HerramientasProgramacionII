using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BankAccount
    {
        //al ser un atributo estático, la clase es quien administra la variable
        private static int numeroCuenta=1000000;
        private string nombreTitular;
        private double saldo;

        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string NombreTitular { get => nombreTitular; set => nombreTitular = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public BankAccount() {
            //por ser estático, la clase lleva la cuenta incremental, no los objetos
            numeroCuenta++;


        }


    }
}
