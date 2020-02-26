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
        private List<Transaccion> historico;

        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string NombreTitular { get => nombreTitular; set => nombreTitular = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        internal List<Transaccion> Historico { get => historico; set => historico = value; }

        public BankAccount(string nombre) {
            //por ser estático, la clase lleva la cuenta incremental, no los objetos
            numeroCuenta++;
            nombreTitular = nombre;
            saldo = 50000;
            historico = new List<Transaccion>();
        }
        public BankAccount(string nombre, double inicial) {
            numeroCuenta++;
            nombreTitular = nombre;
            saldo = inicial;
            historico = new List<Transaccion>();

        }

        public void makeDeposit(double dinero){
            saldo+=dinero;
            Transaccion dep = new Transaccion(DateTime.Now, dinero,"deposito");
            historico.Add(dep);            
        }

        public void MakeWithdrawal(double dinero){
            
            if(dinero>saldo){
                throw new Exception("No es posible realizar el retiro");
            }
            else
            {
                saldo-=dinero;
                Transaccion ret = new Transaccion(DateTime.Now, dinero, "retiro");
                historico.Add(ret);
            }   

        }

    }
}
