using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    interface Ifigura
    {
        double CalcularArea();
        double CalcularPerimetro();
        void Mensaje(string x);
    }
}
