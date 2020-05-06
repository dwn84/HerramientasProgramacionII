namespace ConexionDB
{
    partial class frmArticulo
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
            this.dgvArt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPro = new System.Windows.Forms.ComboBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.txtPre = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArt
            // 
            this.dgvArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArt.Location = new System.Drawing.Point(265, 58);
            this.dgvArt.Name = "dgvArt";
            this.dgvArt.Size = new System.Drawing.Size(756, 297);
            this.dgvArt.TabIndex = 0;
            this.dgvArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArt_CellContentClick);
            this.dgvArt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArt_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de artículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(99, 58);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 3;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(99, 106);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Categoria";
            // 
            // cmbPro
            // 
            this.cmbPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPro.FormattingEnabled = true;
            this.cmbPro.Location = new System.Drawing.Point(99, 217);
            this.cmbPro.Name = "cmbPro";
            this.cmbPro.Size = new System.Drawing.Size(100, 21);
            this.cmbPro.TabIndex = 10;
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(99, 269);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(100, 21);
            this.cmbCat.TabIndex = 11;
            // 
            // txtPre
            // 
            this.txtPre.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtPre.Location = new System.Drawing.Point(99, 163);
            this.txtPre.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(100, 20);
            this.txtPre.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(22, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(184, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(103, 326);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(27, 368);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(232, 23);
            this.btnCategorias.TabIndex = 16;
            this.btnCategorias.Text = "Gestionar Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 403);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.cmbPro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArt);
            this.Name = "frmArticulo";
            this.Text = "Gestión de artículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArticulo_FormClosing);
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPro;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.NumericUpDown txtPre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCategorias;
    }
}