namespace CuentaBancaria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSaldoAhorros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsignarA = new System.Windows.Forms.Button();
            this.btnRetirarA = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRetirarC = new System.Windows.Forms.Button();
            this.btnConsignarC = new System.Windows.Forms.Button();
            this.txtSaldoCorriente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAvanzarMes = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuentaBancaria.Properties.Resources.banco;
            this.pictureBox1.Location = new System.Drawing.Point(125, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAvanzarMes);
            this.groupBox2.Controls.Add(this.txtMes);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(22, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 382);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información bancaria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(298, 31);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRetirarA);
            this.groupBox3.Controls.Add(this.btnConsignarA);
            this.groupBox3.Controls.Add(this.txtSaldoAhorros);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(21, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta de ahorros";
            // 
            // txtSaldoAhorros
            // 
            this.txtSaldoAhorros.Enabled = false;
            this.txtSaldoAhorros.Location = new System.Drawing.Point(69, 34);
            this.txtSaldoAhorros.Name = "txtSaldoAhorros";
            this.txtSaldoAhorros.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoAhorros.TabIndex = 5;
            this.txtSaldoAhorros.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // btnConsignarA
            // 
            this.btnConsignarA.Location = new System.Drawing.Point(205, 32);
            this.btnConsignarA.Name = "btnConsignarA";
            this.btnConsignarA.Size = new System.Drawing.Size(75, 23);
            this.btnConsignarA.TabIndex = 6;
            this.btnConsignarA.Text = "Consignar";
            this.btnConsignarA.UseVisualStyleBackColor = true;
            this.btnConsignarA.Click += new System.EventHandler(this.btnConsignarA_Click);
            // 
            // btnRetirarA
            // 
            this.btnRetirarA.Location = new System.Drawing.Point(302, 31);
            this.btnRetirarA.Name = "btnRetirarA";
            this.btnRetirarA.Size = new System.Drawing.Size(75, 23);
            this.btnRetirarA.TabIndex = 7;
            this.btnRetirarA.Text = "Retirar";
            this.btnRetirarA.UseVisualStyleBackColor = true;
            this.btnRetirarA.Click += new System.EventHandler(this.btnRetirarA_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRetirarC);
            this.groupBox4.Controls.Add(this.btnConsignarC);
            this.groupBox4.Controls.Add(this.txtSaldoCorriente);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(21, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 110);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cuenta corriente";
            // 
            // btnRetirarC
            // 
            this.btnRetirarC.Location = new System.Drawing.Point(302, 31);
            this.btnRetirarC.Name = "btnRetirarC";
            this.btnRetirarC.Size = new System.Drawing.Size(75, 23);
            this.btnRetirarC.TabIndex = 7;
            this.btnRetirarC.Text = "Retirar";
            this.btnRetirarC.UseVisualStyleBackColor = true;
            this.btnRetirarC.Click += new System.EventHandler(this.btnRetirarC_Click);
            // 
            // btnConsignarC
            // 
            this.btnConsignarC.Location = new System.Drawing.Point(205, 32);
            this.btnConsignarC.Name = "btnConsignarC";
            this.btnConsignarC.Size = new System.Drawing.Size(75, 23);
            this.btnConsignarC.TabIndex = 6;
            this.btnConsignarC.Text = "Consignar";
            this.btnConsignarC.UseVisualStyleBackColor = true;
            this.btnConsignarC.Click += new System.EventHandler(this.btnConsignarC_Click);
            // 
            // txtSaldoCorriente
            // 
            this.txtSaldoCorriente.Enabled = false;
            this.txtSaldoCorriente.Location = new System.Drawing.Point(69, 34);
            this.txtSaldoCorriente.Name = "txtSaldoCorriente";
            this.txtSaldoCorriente.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoCorriente.TabIndex = 5;
            this.txtSaldoCorriente.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saldo";
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(90, 294);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 9;
            this.txtMes.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mes";
            // 
            // btnAvanzarMes
            // 
            this.btnAvanzarMes.Location = new System.Drawing.Point(226, 292);
            this.btnAvanzarMes.Name = "btnAvanzarMes";
            this.btnAvanzarMes.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzarMes.TabIndex = 8;
            this.btnAvanzarMes.Text = "Avanzar mes";
            this.btnAvanzarMes.UseVisualStyleBackColor = true;
            this.btnAvanzarMes.Click += new System.EventHandler(this.btnAvanzarMes_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(323, 334);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAvanzarMes;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRetirarC;
        private System.Windows.Forms.Button btnConsignarC;
        private System.Windows.Forms.TextBox txtSaldoCorriente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRetirarA;
        private System.Windows.Forms.Button btnConsignarA;
        private System.Windows.Forms.TextBox txtSaldoAhorros;
        private System.Windows.Forms.Label label3;
    }
}

