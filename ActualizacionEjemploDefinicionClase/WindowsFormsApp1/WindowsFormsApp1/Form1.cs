using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        BankAccount cuentaBancaria;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona Jaime = new Persona();
           // MessageBox.Show(Jaime.Addres);
            Jaime.Addres = "Cra 33 #33-33";
            Jaime.Cellphone = "3012223366";
           // MessageBox.Show(Jaime.Cellphone);
           /*
            Persona Milena = new Persona("Milena");
            Persona Esperanza = new Persona("Esperanza","Calle 1");
            Persona Eddie = new Persona("Eddie", "Calle 6", "301222555");
            Persona Ivan = new Persona("Ivan",cellphone:"315666666");

            BankAccount colmena = new BankAccount("mario");
            MessageBox.Show("Número de cuenta colmena: " + colmena.NumeroCuenta.ToString());

            BankAccount sudameris = new BankAccount("Luigi");
            MessageBox.Show("Número de cuenta sudameris: " + sudameris.NumeroCuenta.ToString());

            BankAccount bancodo = new BankAccount("Cupa");
            MessageBox.Show("Número de cuenta bancocodo: " + bancodo.NumeroCuenta.ToString());

            try
            {
                colmena.MakeWithdrawal(100000);
                MessageBox.Show("Retiro exitoso, el nuevo saldo es: "+colmena.Saldo);
            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message);
            }
            */
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (txtTitular.Text != "" && txtSaldo.Text != "")
            {
                cuentaBancaria = new BankAccount(txtTitular.Text, Convert.ToDouble(txtSaldo.Text));
                lblNumeroCuenta.Text = cuentaBancaria.NumeroCuenta.ToString();
                lblSaldo.Text = cuentaBancaria.Saldo.ToString();
                groupBox2.Enabled = true;
            }
            else if (txtTitular.Text != "" && txtSaldo.Text == "")
            {
                cuentaBancaria = new BankAccount(txtTitular.Text);
                lblNumeroCuenta.Text = cuentaBancaria.NumeroCuenta.ToString();
                lblSaldo.Text = cuentaBancaria.Saldo.ToString();
                groupBox2.Enabled = true;
            }
            else {
                MessageBox.Show("Se necesita el nombre del titular");
                txtTitular.Focus();
            }


        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (rbtnConsignar.Checked)
            {
                cuentaBancaria.makeDeposit(Convert.ToDouble(txtDinero.Text));
                MessageBox.Show("Depósito exitoso");
            }
            else 
            {
                try
                {
                    cuentaBancaria.MakeWithdrawal(Convert.ToDouble(txtDinero.Text));
                    MessageBox.Show("Retiro exitoso");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
            lblSaldo.Text = cuentaBancaria.Saldo.ToString();
        }
    }
}
