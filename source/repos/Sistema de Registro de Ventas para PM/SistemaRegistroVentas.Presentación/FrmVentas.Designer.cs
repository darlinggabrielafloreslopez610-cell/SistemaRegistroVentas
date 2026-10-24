namespace SistemaRegistroVentas.Presentación
{
    partial class FrmVentas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnventas = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.grpEncabezado = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblSubtotalLbl = new System.Windows.Forms.Label();
            this.lblSubtotalVal = new System.Windows.Forms.Label();
            this.lblDescuentoLbl = new System.Windows.Forms.Label();
            this.lblDescuentoVal = new System.Windows.Forms.Label();
            this.lblImpuestoLbl = new System.Windows.Forms.Label();
            this.lblImpuestoVal = new System.Windows.Forms.Label();
            this.lblTotalLbl = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.grpEncabezado.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.btnventas);
            this.pnlHeader.Controls.Add(this.lblEncabezado);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1160, 62);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnventas
            // 
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.Color.White;
            this.btnventas.Location = new System.Drawing.Point(0, 0);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(38, 62);
            this.btnventas.TabIndex = 1;
            this.btnventas.Text = "⬅";
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI Black", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(1160, 62);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Registro de Ventas";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEncabezado.Click += new System.EventHandler(this.lblEncabezado_Click);
            // 
            // grpEncabezado
            // 
            this.grpEncabezado.BackColor = System.Drawing.Color.LightGray;
            this.grpEncabezado.Controls.Add(this.lblCliente);
            this.grpEncabezado.Controls.Add(this.cmbCliente);
            this.grpEncabezado.Controls.Add(this.lblEmpleado);
            this.grpEncabezado.Controls.Add(this.cmbEmpleado);
            this.grpEncabezado.Controls.Add(this.lblFecha);
            this.grpEncabezado.Controls.Add(this.dtpFecha);
            this.grpEncabezado.Controls.Add(this.lblMetodoPago);
            this.grpEncabezado.Controls.Add(this.cmbMetodoPago);
            this.grpEncabezado.Controls.Add(this.lblDescuento);
            this.grpEncabezado.Controls.Add(this.txtDescuento);
            this.grpEncabezado.Controls.Add(this.lblImpuesto);
            this.grpEncabezado.Controls.Add(this.txtImpuesto);
            this.grpEncabezado.Controls.Add(this.btnRegistrar);
            this.grpEncabezado.Controls.Add(this.btnLimpiar);
            this.grpEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpEncabezado.Location = new System.Drawing.Point(13, 76);
            this.grpEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.grpEncabezado.Name = "grpEncabezado";
            this.grpEncabezado.Padding = new System.Windows.Forms.Padding(4);
            this.grpEncabezado.Size = new System.Drawing.Size(328, 615);
            this.grpEncabezado.TabIndex = 1;
            this.grpEncabezado.TabStop = false;
            this.grpEncabezado.Text = "Encabezado de Venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCliente.Location = new System.Drawing.Point(13, 32);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmbCliente.Location = new System.Drawing.Point(13, 54);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(284, 25);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblEmpleado.Location = new System.Drawing.Point(13, 98);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(79, 18);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmbEmpleado.Location = new System.Drawing.Point(13, 121);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(284, 25);
            this.cmbEmpleado.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblFecha.Location = new System.Drawing.Point(13, 165);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 18);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(13, 187);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(284, 24);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMetodoPago.Location = new System.Drawing.Point(13, 231);
            this.lblMetodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(122, 18);
            this.lblMetodoPago.TabIndex = 6;
            this.lblMetodoPago.Text = "Método de Pago:";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.cmbMetodoPago.Location = new System.Drawing.Point(13, 254);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(284, 25);
            this.cmbMetodoPago.TabIndex = 7;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblDescuento.Location = new System.Drawing.Point(13, 298);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(111, 18);
            this.lblDescuento.TabIndex = 8;
            this.lblDescuento.Text = "Descuento (%):";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtDescuento.Location = new System.Drawing.Point(13, 320);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(89, 24);
            this.txtDescuento.TabIndex = 9;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblImpuesto.Location = new System.Drawing.Point(13, 363);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(100, 18);
            this.lblImpuesto.TabIndex = 10;
            this.lblImpuesto.Text = "Impuesto (%):";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtImpuesto.Location = new System.Drawing.Point(13, 385);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(105, 24);
            this.txtImpuesto.TabIndex = 11;
            this.txtImpuesto.Text = "0";
            this.txtImpuesto.TextChanged += new System.EventHandler(this.txtImpuesto_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(29, 441);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(268, 55);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar Venta";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(115)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 521);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(268, 47);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpDetalle
            // 
            this.grpDetalle.BackColor = System.Drawing.Color.LightGray;
            this.grpDetalle.Controls.Add(this.txtProducto);
            this.grpDetalle.Controls.Add(this.lblProducto);
            this.grpDetalle.Controls.Add(this.lblCantidad);
            this.grpDetalle.Controls.Add(this.txtCantidad);
            this.grpDetalle.Controls.Add(this.btnAgregarDetalle);
            this.grpDetalle.Controls.Add(this.dgvDetalle);
            this.grpDetalle.Controls.Add(this.lblSubtotalLbl);
            this.grpDetalle.Controls.Add(this.lblSubtotalVal);
            this.grpDetalle.Controls.Add(this.lblDescuentoLbl);
            this.grpDetalle.Controls.Add(this.lblDescuentoVal);
            this.grpDetalle.Controls.Add(this.lblImpuestoLbl);
            this.grpDetalle.Controls.Add(this.lblImpuestoVal);
            this.grpDetalle.Controls.Add(this.lblTotalLbl);
            this.grpDetalle.Controls.Add(this.lblTotalVal);
            this.grpDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetalle.Location = new System.Drawing.Point(376, 76);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetalle.Size = new System.Drawing.Size(771, 615);
            this.grpDetalle.TabIndex = 2;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle De Venta";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(94, 33);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(346, 24);
            this.txtProducto.TabIndex = 14;
            this.txtProducto.Click += new System.EventHandler(this.btnagregar);
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblProducto.Location = new System.Drawing.Point(13, 33);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 18);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCantidad.Location = new System.Drawing.Point(447, 33);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(47, 18);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cant.:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txtCantidad.Location = new System.Drawing.Point(511, 30);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 24);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "1";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(597, 27);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(157, 34);
            this.btnAgregarDetalle.TabIndex = 4;
            this.btnAgregarDetalle.Text = "+ Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(13, 76);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.Size = new System.Drawing.Size(744, 382);
            this.dgvDetalle.TabIndex = 5;
            this.dgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // lblSubtotalLbl
            // 
            this.lblSubtotalLbl.AutoSize = true;
            this.lblSubtotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubtotalLbl.Location = new System.Drawing.Point(407, 476);
            this.lblSubtotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalLbl.Name = "lblSubtotalLbl";
            this.lblSubtotalLbl.Size = new System.Drawing.Size(66, 18);
            this.lblSubtotalLbl.TabIndex = 6;
            this.lblSubtotalLbl.Text = "Subtotal:";
            // 
            // lblSubtotalVal
            // 
            this.lblSubtotalVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubtotalVal.Location = new System.Drawing.Point(645, 476);
            this.lblSubtotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalVal.Name = "lblSubtotalVal";
            this.lblSubtotalVal.Size = new System.Drawing.Size(53, 22);
            this.lblSubtotalVal.TabIndex = 7;
            this.lblSubtotalVal.Text = "$0.00";
            this.lblSubtotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescuentoLbl
            // 
            this.lblDescuentoLbl.AutoSize = true;
            this.lblDescuentoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescuentoLbl.ForeColor = System.Drawing.Color.Crimson;
            this.lblDescuentoLbl.Location = new System.Drawing.Point(407, 505);
            this.lblDescuentoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuentoLbl.Name = "lblDescuentoLbl";
            this.lblDescuentoLbl.Size = new System.Drawing.Size(103, 18);
            this.lblDescuentoLbl.TabIndex = 8;
            this.lblDescuentoLbl.Text = "Descuento (-):";
            // 
            // lblDescuentoVal
            // 
            this.lblDescuentoVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescuentoVal.ForeColor = System.Drawing.Color.Crimson;
            this.lblDescuentoVal.Location = new System.Drawing.Point(648, 505);
            this.lblDescuentoVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuentoVal.Name = "lblDescuentoVal";
            this.lblDescuentoVal.Size = new System.Drawing.Size(50, 22);
            this.lblDescuentoVal.TabIndex = 9;
            this.lblDescuentoVal.Text = "$0.00";
            this.lblDescuentoVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescuentoVal.Click += new System.EventHandler(this.lblDescuentoVal_Click);
            // 
            // lblImpuestoLbl
            // 
            this.lblImpuestoLbl.AutoSize = true;
            this.lblImpuestoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblImpuestoLbl.Location = new System.Drawing.Point(407, 535);
            this.lblImpuestoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuestoLbl.Name = "lblImpuestoLbl";
            this.lblImpuestoLbl.Size = new System.Drawing.Size(96, 18);
            this.lblImpuestoLbl.TabIndex = 10;
            this.lblImpuestoLbl.Text = "Impuesto (+):";
            // 
            // lblImpuestoVal
            // 
            this.lblImpuestoVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblImpuestoVal.Location = new System.Drawing.Point(604, 533);
            this.lblImpuestoVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuestoVal.Name = "lblImpuestoVal";
            this.lblImpuestoVal.Size = new System.Drawing.Size(94, 22);
            this.lblImpuestoVal.TabIndex = 11;
            this.lblImpuestoVal.Text = "$0.00";
            this.lblImpuestoVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblImpuestoVal.Click += new System.EventHandler(this.lblImpuestoVal_Click);
            // 
            // lblTotalLbl
            // 
            this.lblTotalLbl.AutoSize = true;
            this.lblTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalLbl.Location = new System.Drawing.Point(406, 564);
            this.lblTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLbl.Name = "lblTotalLbl";
            this.lblTotalLbl.Size = new System.Drawing.Size(83, 24);
            this.lblTotalLbl.TabIndex = 12;
            this.lblTotalLbl.Text = "TOTAL:";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalVal.Location = new System.Drawing.Point(585, 555);
            this.lblTotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(130, 31);
            this.lblTotalVal.TabIndex = 13;
            this.lblTotalVal.Text = "$0.00";
            this.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1160, 708);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpEncabezado);
            this.Controls.Add(this.grpDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.pnlHeader.ResumeLayout(false);
            this.grpEncabezado.ResumeLayout(false);
            this.grpEncabezado.PerformLayout();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.GroupBox grpEncabezado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblSubtotalLbl;
        private System.Windows.Forms.Label lblSubtotalVal;
        private System.Windows.Forms.Label lblDescuentoLbl;
        private System.Windows.Forms.Label lblDescuentoVal;
        private System.Windows.Forms.Label lblImpuestoLbl;
        private System.Windows.Forms.Label lblImpuestoVal;
        private System.Windows.Forms.Label lblTotalLbl;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.TextBox txtProducto;
    }
}
