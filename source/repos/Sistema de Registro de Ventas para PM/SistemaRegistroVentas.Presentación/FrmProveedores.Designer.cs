namespace SistemaRegistroVentas.Presentación
{
    partial class FrmProveedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcédula = new System.Windows.Forms.TextBox();
            this.lblcédula = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtteléfono = new System.Windows.Forms.TextBox();
            this.txtdirección = new System.Windows.Forms.TextBox();
            this.txtnempresa = new System.Windows.Forms.TextBox();
            this.txtcódigo = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lblteléfono = new System.Windows.Forms.Label();
            this.lbldirección = new System.Windows.Forms.Label();
            this.lblnempresa = new System.Windows.Forms.Label();
            this.lblcódigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnproveedores = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado De Proveedores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtcédula);
            this.groupBox1.Controls.Add(this.lblcédula);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.txtteléfono);
            this.groupBox1.Controls.Add(this.txtdirección);
            this.groupBox1.Controls.Add(this.txtnempresa);
            this.groupBox1.Controls.Add(this.txtcódigo);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.lblcorreo);
            this.groupBox1.Controls.Add(this.lblteléfono);
            this.groupBox1.Controls.Add(this.lbldirección);
            this.groupBox1.Controls.Add(this.lblnempresa);
            this.groupBox1.Controls.Add(this.lblcódigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 542);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Proveedor";
            // 
            // txtcédula
            // 
            this.txtcédula.Location = new System.Drawing.Point(164, 237);
            this.txtcédula.Name = "txtcédula";
            this.txtcédula.Size = new System.Drawing.Size(172, 22);
            this.txtcédula.TabIndex = 15;
            // 
            // lblcédula
            // 
            this.lblcédula.AutoSize = true;
            this.lblcédula.Location = new System.Drawing.Point(20, 237);
            this.lblcédula.Name = "lblcédula";
            this.lblcédula.Size = new System.Drawing.Size(56, 16);
            this.lblcédula.TabIndex = 14;
            this.lblcédula.Text = "Cédula";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(164, 200);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(172, 22);
            this.txtcorreo.TabIndex = 13;
            // 
            // txtteléfono
            // 
            this.txtteléfono.Location = new System.Drawing.Point(164, 166);
            this.txtteléfono.Name = "txtteléfono";
            this.txtteléfono.Size = new System.Drawing.Size(100, 22);
            this.txtteléfono.TabIndex = 12;
            // 
            // txtdirección
            // 
            this.txtdirección.Location = new System.Drawing.Point(164, 123);
            this.txtdirección.Name = "txtdirección";
            this.txtdirección.Size = new System.Drawing.Size(172, 22);
            this.txtdirección.TabIndex = 11;
            // 
            // txtnempresa
            // 
            this.txtnempresa.Location = new System.Drawing.Point(164, 90);
            this.txtnempresa.Name = "txtnempresa";
            this.txtnempresa.Size = new System.Drawing.Size(172, 22);
            this.txtnempresa.TabIndex = 10;
            // 
            // txtcódigo
            // 
            this.txtcódigo.Location = new System.Drawing.Point(164, 54);
            this.txtcódigo.Name = "txtcódigo";
            this.txtcódigo.ReadOnly = true;
            this.txtcódigo.Size = new System.Drawing.Size(100, 22);
            this.txtcódigo.TabIndex = 9;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpiar.Location = new System.Drawing.Point(16, 464);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(320, 50);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.Location = new System.Drawing.Point(16, 399);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(320, 50);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Teal;
            this.btnmodificar.Location = new System.Drawing.Point(16, 333);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(320, 50);
            this.btnmodificar.TabIndex = 6;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Green;
            this.btnagregar.Location = new System.Drawing.Point(13, 277);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(323, 50);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(13, 203);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(136, 16);
            this.lblcorreo.TabIndex = 4;
            this.lblcorreo.Text = "Correo Electrónico";
            // 
            // lblteléfono
            // 
            this.lblteléfono.AutoSize = true;
            this.lblteléfono.Location = new System.Drawing.Point(17, 169);
            this.lblteléfono.Name = "lblteléfono";
            this.lblteléfono.Size = new System.Drawing.Size(69, 16);
            this.lblteléfono.TabIndex = 3;
            this.lblteléfono.Text = "Teléfono";
            // 
            // lbldirección
            // 
            this.lbldirección.AutoSize = true;
            this.lbldirección.Location = new System.Drawing.Point(13, 129);
            this.lbldirección.Name = "lbldirección";
            this.lbldirección.Size = new System.Drawing.Size(73, 16);
            this.lbldirección.TabIndex = 2;
            this.lbldirección.Text = "Dirección";
            // 
            // lblnempresa
            // 
            this.lblnempresa.AutoSize = true;
            this.lblnempresa.Location = new System.Drawing.Point(10, 93);
            this.lblnempresa.Name = "lblnempresa";
            this.lblnempresa.Size = new System.Drawing.Size(128, 16);
            this.lblnempresa.TabIndex = 1;
            this.lblnempresa.Text = "Nombre Empresa";
            // 
            // lblcódigo
            // 
            this.lblcódigo.AutoSize = true;
            this.lblcódigo.Location = new System.Drawing.Point(10, 57);
            this.lblcódigo.Name = "lblcódigo";
            this.lblcódigo.Size = new System.Drawing.Size(57, 16);
            this.lblcódigo.TabIndex = 0;
            this.lblcódigo.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(375, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 542);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Proveedores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnproveedores
            // 
            this.btnproveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedores.ForeColor = System.Drawing.Color.Transparent;
            this.btnproveedores.Location = new System.Drawing.Point(-4, -4);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(45, 62);
            this.btnproveedores.TabIndex = 3;
            this.btnproveedores.Text = "⬅";
            this.btnproveedores.UseVisualStyleBackColor = false;
            this.btnproveedores.Click += new System.EventHandler(this.btnproveedores_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 629);
            this.Controls.Add(this.btnproveedores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lblteléfono;
        private System.Windows.Forms.Label lbldirección;
        private System.Windows.Forms.Label lblnempresa;
        private System.Windows.Forms.Label lblcódigo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtteléfono;
        private System.Windows.Forms.TextBox txtdirección;
        private System.Windows.Forms.TextBox txtnempresa;
        private System.Windows.Forms.TextBox txtcódigo;
        private System.Windows.Forms.TextBox txtcédula;
        private System.Windows.Forms.Label lblcédula;
        private System.Windows.Forms.Button btnproveedores;
    }
}