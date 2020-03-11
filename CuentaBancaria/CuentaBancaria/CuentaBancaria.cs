using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaBancaria
{
    class CuentaBancaria
    {
        //variables para almacenar informacion
        private string nombre;
        private string cedula;
        private double saldoAhorros;
        private double saldoCorriente;
        private byte mes;

        //creacion de propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public double SaldoAhorros { get => saldoAhorros; set => saldoAhorros = value; }
        public double SaldoCorriente { get => saldoCorriente; set => saldoCorriente = value; }
        public byte Mes { get => mes; set => mes = value; }

        //definir el constructor
        public CuentaBancaria()
        {
            nombre = "Eddie";
            cedula = "71555555";
            mes = 1;
        }

        //definir las acciones... métodos
        public double Consignar(double dinero, string tipo, TextBox resultado)
        {
            switch (tipo)
            {
                case "ahorros":
                    saldoAhorros += dinero;
                    resultado.Text = saldoAhorros.ToString();
                    break;
                case "corriente":
                    saldoCorriente += dinero;
                    resultado.Text = saldoCorriente.ToString();

                    break;
                default:
                    throw new Exception("Tipo de consignacion incorrecta");

            }

            return saldoAhorros + saldoCorriente;
        }

        private Boolean ValidarSaldo(double dinero, string tipo) {
            switch (tipo)
            {
                case "ahorros":
                    if (dinero > saldoAhorros)
                    {
                        return false;

                    }
                    break;
                case "corriente":
                    if (dinero > SaldoCorriente)
                    {
                        return false;
                    }
                    break;
                default:
                    throw new Exception("Validación incorrecta");
            }
            return true;

        }

        public double Retirar(double dinero, string tipo, TextBox resultado)
        {

            switch (tipo)
            {
                case "ahorros":
                    if (ValidarSaldo(dinero, tipo) == true)
                    {
                        saldoAhorros -= dinero;
                        resultado.Text = saldoAhorros.ToString();
                    }
                    else
                    {
                        throw new Exception("No hay dinero suficiente en la cuenta de ahorros");
                    }

                    break;
                case "corriente":
                    if (ValidarSaldo(dinero, tipo) == true)
                    {
                        saldoCorriente -= dinero;
                        resultado.Text = saldoCorriente.ToString();
                    }
                    else
                    {
                        throw new Exception("No hay dinero suficiente en la cuenta coriente");
                    }

                    break;
                default:
                    throw new Exception("Tipo de consignacion incorrecta");

            }

            return saldoAhorros + saldoCorriente;
        }

        public void AvanzarMes(TextBox mes, TextBox total)
        {
            byte m = byte.Parse(mes.Text);
            if (m >= 12)
            {
                throw new Exception("No se puede avanzar mas de un año");
            }
            else 
            {
                m++;
                mes.Text = m.ToString();
            }
            saldoAhorros = saldoAhorros + (saldoAhorros * 0.006);
            total.Text = (saldoAhorros + saldoCorriente).ToString();
        }
    }
}
