using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    class Triangulo : Figura
    {

        private double bs;
        private double al;

        public Triangulo(double bs, double al, string color) : base(color) 
        {
            this.bs = bs;
            this.al = al;
        }

        public double Bs { get => bs; set => bs = value; }
        public double Al { get => al; set => al = value; }

        public override double CalcularArea()
        {
            double area = (bs * al) / 2;
            return area;
        }
    }
}
