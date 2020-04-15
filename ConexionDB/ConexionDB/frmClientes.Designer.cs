namespace ConexionDB
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFec = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lsbClientes = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscarCed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditNom = new System.Windows.Forms.TextBox();
            this.txtEditApe = new System.Windows.Forms.TextBox();
            this.txtEditBar = new System.Windows.Forms.TextBox();
            this.dtpEditFec = new System.Windows.Forms.DateTimePicker();
            this.cmbEditGen = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(165, 34);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(100, 20);
            this.txtCed.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(165, 73);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(165, 116);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(165, 225);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(100, 20);
            this.txtBarrio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barrio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha nacimiento";
            // 
            // dtpFec
            // 
            this.dtpFec.CustomFormat = "yyyy-MM-dd";
            this.dtpFec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFec.Location = new System.Drawing.Point(165, 158);
            this.dtpFec.Name = "dtpFec";
            this.dtpFec.Size = new System.Drawing.Size(100, 20);
            this.dtpFec.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Género";
            // 
            // cmbGen
            // 
            this.cmbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGen.Location = new System.Drawing.Point(165, 190);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(100, 21);
            this.cmbGen.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(103, 269);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Crear nuevo cliente";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lsbClientes
            // 
            this.lsbClientes.FormattingEnabled = true;
            this.lsbClientes.Location = new System.Drawing.Point(316, 73);
            this.lsbClientes.Name = "lsbClientes";
            this.lsbClientes.Size = new System.Drawing.Size(295, 225);
            this.lsbClientes.TabIndex = 13;
            this.lsbClientes.SelectedIndexChanged += new System.EventHandler(this.lsbClientes_SelectedIndexChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(316, 32);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(167, 23);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar Clientes registrados";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(72, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.cmbEditGen);
            this.groupBox1.Controls.Add(this.dtpEditFec);
            this.groupBox1.Controls.Add(this.txtEditBar);
            this.groupBox1.Controls.Add(this.txtEditApe);
            this.groupBox1.Controls.Add(this.txtEditNom);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBuscarCed);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(672, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 336);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar información de cliente";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(6, 307);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 23);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Género";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Barrio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Apellido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nombre";
            // 
            // txtBuscarCed
            // 
            this.txtBuscarCed.Location = new System.Drawing.Point(91, 30);
            this.txtBuscarCed.Name = "txtBuscarCed";
            this.txtBuscarCed.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCed.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cédula";
            // 
            // txtEditNom
            // 
            this.txtEditNom.Enabled = false;
            this.txtEditNom.Location = new System.Drawing.Point(128, 100);
            this.txtEditNom.Name = "txtEditNom";
            this.txtEditNom.Size = new System.Drawing.Size(100, 20);
            this.txtEditNom.TabIndex = 30;
            // 
            // txtEditApe
            // 
            this.txtEditApe.Enabled = false;
            this.txtEditApe.Location = new System.Drawing.Point(128, 139);
            this.txtEditApe.Name = "txtEditApe";
            this.txtEditApe.Size = new System.Drawing.Size(100, 20);
            this.txtEditApe.TabIndex = 31;
            // 
            // txtEditBar
            // 
            this.txtEditBar.Enabled = false;
            this.txtEditBar.Location = new System.Drawing.Point(128, 255);
            this.txtEditBar.Name = "txtEditBar";
            this.txtEditBar.Size = new System.Drawing.Size(100, 20);
            this.txtEditBar.TabIndex = 34;
            // 
            // dtpEditFec
            // 
            this.dtpEditFec.CustomFormat = "yyyy-MM-dd";
            this.dtpEditFec.Enabled = false;
            this.dtpEditFec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditFec.Location = new System.Drawing.Point(128, 178);
            this.dtpEditFec.Name = "dtpEditFec";
            this.dtpEditFec.Size = new System.Drawing.Size(100, 20);
            this.dtpEditFec.TabIndex = 19;
            // 
            // cmbEditGen
            // 
            this.cmbEditGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditGen.Enabled = false;
            this.cmbEditGen.FormattingEnabled = true;
            this.cmbEditGen.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbEditGen.Location = new System.Drawing.Point(128, 217);
            this.cmbEditGen.Name = "cmbEditGen";
            this.cmbEditGen.Size = new System.Drawing.Size(100, 21);
            this.cmbEditGen.TabIndex = 19;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(133, 307);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 23);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lsbClientes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "Ingresar datos nuevo cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClientes_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lsbClientes;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscarCed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbEditGen;
        private System.Windows.Forms.DateTimePicker dtpEditFec;
        private System.Windows.Forms.TextBox txtEditBar;
        private System.Windows.Forms.TextBox txtEditApe;
        private System.Windows.Forms.TextBox txtEditNom;
        private System.Windows.Forms.Button btnActualizar;
    }
}