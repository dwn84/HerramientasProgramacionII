using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPolimorfismo
{
    class Cuadrado : Ifigura,Irotable
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double Lado { get => lado; set => lado = value; }

        public double CalcularArea()
        {
            double area = lado * lado;
            return area;
        }

        public double CalcularPerimetro()
        {
            return lado * 4;        
        }

        public void Mensaje(string x)
        {
            System.Windows.Forms.MessageBox.Show("Hola, soy un cuadrado!");
        }

        public void Rotar(int grados)
        {
            System.Windows.Forms.MessageBox.Show("Rotando " + grados);
        }
    }
}
