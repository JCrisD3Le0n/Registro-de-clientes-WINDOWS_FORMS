
namespace Lab2Asi_DS23003
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbCombustible = new System.Windows.Forms.ComboBox();
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.gbClienteDatos = new System.Windows.Forms.GroupBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbClienteDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(194, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cbCombustible
            // 
            this.cbCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombustible.FormattingEnabled = true;
            this.cbCombustible.Items.AddRange(new object[] {
            "Diesel",
            "Regular"});
            this.cbCombustible.Location = new System.Drawing.Point(194, 125);
            this.cbCombustible.Name = "cbCombustible";
            this.cbCombustible.Size = new System.Drawing.Size(121, 24);
            this.cbCombustible.TabIndex = 1;
            // 
            // txtGalones
            // 
            this.txtGalones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGalones.Location = new System.Drawing.Point(194, 176);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(100, 22);
            this.txtGalones.TabIndex = 2;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(45, 268);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(101, 23);
            this.btnAgregarCliente.TabIndex = 3;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarResultados.Location = new System.Drawing.Point(45, 297);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(346, 23);
            this.btnMostrarResultados.TabIndex = 4;
            this.btnMostrarResultados.Text = "Mostrar Resultados Generales";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // gbClienteDatos
            // 
            this.gbClienteDatos.Controls.Add(this.lblTotalPagar);
            this.gbClienteDatos.Controls.Add(this.lblTipoCombustible);
            this.gbClienteDatos.Controls.Add(this.lblNombre);
            this.gbClienteDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteDatos.ForeColor = System.Drawing.Color.White;
            this.gbClienteDatos.Location = new System.Drawing.Point(572, 69);
            this.gbClienteDatos.Name = "gbClienteDatos";
            this.gbClienteDatos.Size = new System.Drawing.Size(490, 132);
            this.gbClienteDatos.TabIndex = 5;
            this.gbClienteDatos.TabStop = false;
            this.gbClienteDatos.Text = "Cliente";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(3, 104);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(104, 15);
            this.lblTotalPagar.TabIndex = 2;
            this.lblTotalPagar.Text = "Total  a pagar: ";
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Location = new System.Drawing.Point(3, 61);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(119, 15);
            this.lblTipoCombustible.TabIndex = 1;
            this.lblTipoCombustible.Text = "Tipo Combustible";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.tipoCombustible,
            this.totalPagar});
            this.dataGridViewResultados.Location = new System.Drawing.Point(417, 268);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(645, 170);
            this.dataGridViewResultados.TabIndex = 6;
            this.dataGridViewResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultados_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del cliente";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // tipoCombustible
            // 
            this.tipoCombustible.HeaderText = "Tipo de Combustible";
            this.tipoCombustible.Name = "tipoCombustible";
            this.tipoCombustible.Width = 200;
            // 
            // totalPagar
            // 
            this.totalPagar.HeaderText = "Total $";
            this.totalPagar.Name = "totalPagar";
            this.totalPagar.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opcion de combustible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad de galones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(152, 268);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 54);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(378, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "GASOLINERA SHELL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(149, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Diesel $ 3.50 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(149, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Regular $ 4:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(149, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio por galon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1071, 459);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.gbClienteDatos);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtGalones);
            this.Controls.Add(this.cbCombustible);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gasolinera Shell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbClienteDatos.ResumeLayout(false);
            this.gbClienteDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbCombustible;
        private System.Windows.Forms.TextBox txtGalones;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.GroupBox gbClienteDatos;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

