namespace SistemaRegistroVentas.Presentación
{
    partial class FrmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

     
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdescripción = new System.Windows.Forms.TextBox();
            this.lbldescripción = new System.Windows.Forms.Label();
            this.txtnombrecategoria = new System.Windows.Forms.TextBox();
            this.lblnombrecategoria = new System.Windows.Forms.Label();
            this.lblcódigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvcategorias = new System.Windows.Forms.DataGridView();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.btncategorias = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtdescripción);
            this.groupBox1.Controls.Add(this.lbldescripción);
            this.groupBox1.Controls.Add(this.txtnombrecategoria);
            this.groupBox1.Controls.Add(this.lblnombrecategoria);
            this.groupBox1.Controls.Add(this.lblcódigo);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 531);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos De Categoría";
            // 
            // txtdescripción
            // 
            this.txtdescripción.Location = new System.Drawing.Point(118, 190);
            this.txtdescripción.Name = "txtdescripción";
            this.txtdescripción.Size = new System.Drawing.Size(185, 24);
            this.txtdescripción.TabIndex = 11;
            // 
            // lbldescripción
            // 
            this.lbldescripción.AutoSize = true;
            this.lbldescripción.Location = new System.Drawing.Point(37, 168);
            this.lbldescripción.Name = "lbldescripción";
            this.lbldescripción.Size = new System.Drawing.Size(98, 18);
            this.lbldescripción.TabIndex = 10;
            this.lbldescripción.Text = "Descripción";
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Location = new System.Drawing.Point(118, 141);
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.Size = new System.Drawing.Size(185, 24);
            this.txtnombrecategoria.TabIndex = 9;
            // 
            // lblnombrecategoria
            // 
            this.lblnombrecategoria.AutoSize = true;
            this.lblnombrecategoria.Location = new System.Drawing.Point(34, 110);
            this.lblnombrecategoria.Name = "lblnombrecategoria";
            this.lblnombrecategoria.Size = new System.Drawing.Size(172, 18);
            this.lblnombrecategoria.TabIndex = 8;
            this.lblnombrecategoria.Text = "Nombre De Categoría";
            // 
            // lblcódigo
            // 
            this.lblcódigo.AutoSize = true;
            this.lblcódigo.Location = new System.Drawing.Point(34, 69);
            this.lblcódigo.Name = "lblcódigo";
            this.lblcódigo.Size = new System.Drawing.Size(62, 18);
            this.lblcódigo.TabIndex = 7;
            this.lblcódigo.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(118, 69);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(97, 24);
            this.txtcodigo.TabIndex = 6;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.Location = new System.Drawing.Point(6, 428);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(343, 49);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btneliminar.Location = new System.Drawing.Point(6, 360);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(343, 47);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Teal;
            this.btnmodificar.ForeColor = System.Drawing.Color.Transparent;
            this.btnmodificar.Location = new System.Drawing.Point(6, 297);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(343, 45);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Green;
            this.btnagregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnagregar.Location = new System.Drawing.Point(6, 225);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(343, 49);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.dgvcategorias);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado De Categorías";
            // 
            // dgvcategorias
            // 
            this.dgvcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategorias.Location = new System.Drawing.Point(6, 23);
            this.dgvcategorias.Name = "dgvcategorias";
            this.dgvcategorias.RowHeadersWidth = 51;
            this.dgvcategorias.RowTemplate.Height = 24;
            this.dgvcategorias.Size = new System.Drawing.Size(638, 502);
            this.dgvcategorias.TabIndex = 0;
            this.dgvcategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategorias_CellContentClick);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEncabezado.Font = new System.Drawing.Font("Elephant", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(-3, 9);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(1045, 62);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Gestión De Categorías";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncategorias
            // 
            this.btncategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.ForeColor = System.Drawing.Color.Transparent;
            this.btncategorias.Location = new System.Drawing.Point(2, 12);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(35, 59);
            this.btncategorias.TabIndex = 2;
            this.btncategorias.Text = "⬅";
            this.btncategorias.UseVisualStyleBackColor = false;
            this.btncategorias.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 629);
            this.Controls.Add(this.btncategorias);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión De Categorías";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvcategorias;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcódigo;
        private System.Windows.Forms.Label lblnombrecategoria;
        private System.Windows.Forms.TextBox txtnombrecategoria;
        private System.Windows.Forms.Label lbldescripción;
        private System.Windows.Forms.TextBox txtdescripción;
        private System.Windows.Forms.Button btncategorias;
    }
}