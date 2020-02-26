using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Transaccion
    {

        DateTime registroHorario;
        double monto;
        string tipoOperacion;

        public Transaccion(DateTime rh, double m, string t) 
        {
            Monto = m;
            RegistroHorario = rh;
            TipoOperacion = t;
        }

        public DateTime RegistroHorario { get => registroHorario; set => registroHorario = value; }
        public double Monto { get => monto; set => monto = value; }
        public string TipoOperacion { get => tipoOperacion; set => tipoOperacion = value; }
    }
}
