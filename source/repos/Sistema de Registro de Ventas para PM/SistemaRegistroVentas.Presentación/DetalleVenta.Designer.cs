namespace SistemaRegistroVentas.Presentación
{
    partial class FrmDetalleVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbltot = new System.Windows.Forms.Label();
            this.lblim = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblfacturaN = new System.Windows.Forms.Label();
            this.lblmetododepago = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblsubtotal);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.txtFactura);
            this.panel1.Controls.Add(this.txtMetodoPago);
            this.panel1.Controls.Add(this.txtEmpleado);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lbltot);
            this.panel1.Controls.Add(this.lblim);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lbls);
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.lblfacturaN);
            this.panel1.Controls.Add(this.lblmetododepago);
            this.panel1.Controls.Add(this.lblempleado);
            this.panel1.Controls.Add(this.lblcliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 536);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(637, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Total :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(631, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Impuesto (+) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(631, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Descuento :";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(631, 303);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(80, 20);
            this.lblsubtotal.TabIndex = 16;
            this.lblsubtotal.Text = "Subtotal :";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(605, 116);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(120, 22);
            this.txtFecha.TabIndex = 15;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(605, 81);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 22);
            this.txtFactura.TabIndex = 14;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(254, 149);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(129, 22);
            this.txtMetodoPago.TabIndex = 13;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(254, 114);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(129, 22);
            this.txtEmpleado.TabIndex = 12;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(254, 79);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(129, 22);
            this.txtCliente.TabIndex = 11;
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.Color.Green;
            this.lbltot.Location = new System.Drawing.Point(737, 433);
            this.lbltot.Name = "lbltot";
            this.lbltot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltot.Size = new System.Drawing.Size(66, 25);
            this.lbltot.TabIndex = 10;
            this.lbltot.Text = "$0.00";
            // 
            // lblim
            // 
            this.lblim.AutoSize = true;
            this.lblim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblim.Location = new System.Drawing.Point(754, 397);
            this.lblim.Name = "lblim";
            this.lblim.Size = new System.Drawing.Size(49, 20);
            this.lblim.TabIndex = 9;
            this.lblim.Text = "$0.00";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(754, 353);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(49, 20);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "$0.00";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(754, 303);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(49, 20);
            this.lbls.TabIndex = 7;
            this.lbls.Text = "$0.00";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(18, 213);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(607, 298);
            this.dgvProductos.TabIndex = 6;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(472, 116);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(65, 20);
            this.lblfecha.TabIndex = 5;
            this.lblfecha.Text = "Fecha :";
            // 
            // lblfacturaN
            // 
            this.lblfacturaN.AutoSize = true;
            this.lblfacturaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfacturaN.Location = new System.Drawing.Point(460, 81);
            this.lblfacturaN.Name = "lblfacturaN";
            this.lblfacturaN.Size = new System.Drawing.Size(102, 20);
            this.lblfacturaN.TabIndex = 4;
            this.lblfacturaN.Text = "Factura N# :";
            // 
            // lblmetododepago
            // 
            this.lblmetododepago.AutoSize = true;
            this.lblmetododepago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmetododepago.Location = new System.Drawing.Point(97, 149);
            this.lblmetododepago.Name = "lblmetododepago";
            this.lblmetododepago.Size = new System.Drawing.Size(140, 20);
            this.lblmetododepago.TabIndex = 3;
            this.lblmetododepago.Text = "Método de Pago :";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempleado.Location = new System.Drawing.Point(97, 114);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(93, 20);
            this.lblempleado.TabIndex = 2;
            this.lblempleado.Text = "Empleado :";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(97, 81);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(71, 20);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Cliente :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura De Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 571);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblfacturaN;
        private System.Windows.Forms.Label lblmetododepago;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label lblim;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}