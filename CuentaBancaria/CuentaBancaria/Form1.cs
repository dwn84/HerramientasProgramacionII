using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CuentaBancaria
{
    public partial class Form1 : Form
    {

        CuentaBancaria davivienda;

        public Form1()
        {
            InitializeComponent();
            davivienda = new CuentaBancaria();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCedula.Text = davivienda.Cedula;
            txtNombre.Text = davivienda.Nombre;
        }

        private void btnConsignarA_Click(object sender, EventArgs e)
        {
            double dineroConsignacion = double.Parse(Interaction.InputBox("Cuanto dinero va a consignar?"));
            txtTotal.Text = davivienda.Consignar(dineroConsignacion, "ahorros", txtSaldoAhorros).ToString();
        }

        private void btnRetirarA_Click(object sender, EventArgs e)
        {
            double dineroConsignacion = double.Parse(Interaction.InputBox("Cuanto dinero va a consignar?"));
            try
            {
                txtTotal.Text = davivienda.Retirar(dineroConsignacion, "ahorros", txtSaldoAhorros).ToString();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
            
        }

        private void btnConsignarC_Click(object sender, EventArgs e)
        {
            double dineroConsignacion = double.Parse(Interaction.InputBox("Cuanto dinero va a consignar?"));
            txtTotal.Text = davivienda.Consignar(dineroConsignacion, "corriente", txtSaldoCorriente).ToString();
        }

        private void btnRetirarC_Click(object sender, EventArgs e)
        {
            double dineroConsignacion = double.Parse(Interaction.InputBox("Cuanto dinero va a consignar?"));
            try { 
            txtTotal.Text = davivienda.Retirar(dineroConsignacion, "corriente", txtSaldoCorriente).ToString();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
}

        private void btnAvanzarMes_Click(object sender, EventArgs e)
        {
            try
            {
                davivienda.AvanzarMes(txtMes, txtTotal);
            }
            catch (Exception eee) 
            {
                MessageBox.Show(eee.Message);
            }
            
        }
    }
}
