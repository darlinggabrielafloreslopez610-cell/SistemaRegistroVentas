using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SistemaRegistroVentas.Entidades;
using SistemaRegistroVentas.Negocio;
using System.Linq;

namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmVentas : Form
    {
        private List<Entidades.DetalleVenta> _detalle = new List<Entidades.DetalleVenta>();
        private int _nextDetalleId = 1;

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas();
            EstilarGrilla();
            CargarCombos();

            txtImpuesto.Text = "15";
            txtImpuesto.ReadOnly = true;

            txtDescuento.Text = "0";

            ActualizarTotales();
        }

        private void CargarCombos()
        {
            cmbCliente.DataSource = null;

            List<Clientes> listaClientes = new List<Clientes>();

            listaClientes.Add(new Clientes
            {
                IdCliente = 1,
                Nombre = "Consumidor Final"
            });

            cmbCliente.DataSource = listaClientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "IdCliente";
            cmbCliente.SelectedIndex = 0;


            cmbEmpleado.DataSource = null;

            List<Empleados> listaEmpleados = new List<Empleados>();

            listaEmpleados.Add(new Empleados()
            {
                id_Empleado = "1",
                nombre = "Cajero General"
            });

            listaEmpleados.Add(new Empleados()
            {
                id_Empleado = "2",
                nombre = "Administradora"
            });

            cmbEmpleado.DataSource = listaEmpleados;
            cmbEmpleado.DisplayMember = "nombre";
            cmbEmpleado.ValueMember = "id_Empleado";
            cmbEmpleado.SelectedIndex = 0;

            

          
           
           
           

            
            
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.SelectedIndex = 0;
        }

        private void ConfigurarColumnas()
        {
            
        
            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add("IdDetalle", "#");
            dgvDetalle.Columns.Add("Producto", "Producto");
            dgvDetalle.Columns.Add("Precio", "Precio Unit.");
            dgvDetalle.Columns.Add("Cantidad", "Cant.");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");

            dgvDetalle.Columns["IdDetalle"].Width = 35;
            dgvDetalle.Columns["Precio"].Width = 95;
            dgvDetalle.Columns["Cantidad"].Width = 55;
            dgvDetalle.Columns["Subtotal"].Width = 95;

            dgvDetalle.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDetalle.MultiSelect = false;

            dgvDetalle.ReadOnly = true;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;

            dgvDetalle.EditMode =
                DataGridViewEditMode.EditProgrammatically;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que se haya escrito un producto
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show(
                    "Escriba el nombre del producto.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProducto.Focus();
                return;
            }

            int cantidad;

            // Validar que la cantidad sea válida
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show(
                    "Ingrese una cantidad válida.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidad.Focus();
                return;
            }

            string nombreEscrito = txtProducto.Text.Trim();

            Producto producto = null;
            DataTable dtProductos = NProducto.Consultar();

            foreach (DataRow row in dtProductos.Rows)
            {
                if (row["nombre"].ToString().Trim().Equals(nombreEscrito, StringComparison.OrdinalIgnoreCase))
                {
                    producto = new Producto
                    {
                        id_producto = row["id_producto"].ToString(),
                        nombre = row["nombre"].ToString(),
                        precio = row["precio"].ToString(),
                        stock = row["stock"].ToString()
                    };
                    break;
                }
            }

            if (producto == null)
            {
                MessageBox.Show(
                    "El producto no está registrado. Regístrelo primero para conocer su precio y stock.",
                    "Producto no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProducto.Focus();
                return;
            }

            int stock;

            if (!int.TryParse(producto.stock, out stock))
            {
                MessageBox.Show("El stock del producto no tiene un formato válido.");
                return;
            }

            decimal precio;

            if (!decimal.TryParse(producto.precio, out precio))
            {
                MessageBox.Show("El precio del producto no tiene un formato válido.");
                return;
            }

            if (cantidad > stock)
            {
                MessageBox.Show("No hay suficiente stock. Existencias disponibles: " + stock);
                return;
            }

            // --- NUEVO: Verificar si el producto ya está en el DataGridView para sumarle la cantidad ---
            bool productoEnGrilla = false;

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                // Asegurarse de que la celda del producto no sea nula
                // (Ajusta "Producto" o la columna que use el nombre del producto en tu grilla)
                if (fila.Cells["nombre_producto"].Value != null)
                {
                    string nombreEnGrilla = fila.Cells["nombre_producto"].Value.ToString();

                    if (nombreEnGrilla.Equals(producto.nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        // Obtenemos la cantidad que ya estaba y sumamos la nueva
                        int cantidadActual = Convert.ToInt32(fila.Cells["cantidad"].Value);
                        int nuevaCantidadTotal = cantidadActual + cantidad;

                        // Validar que la suma total no rebase el stock disponible
                        if (nuevaCantidadTotal > stock)
                        {
                            MessageBox.Show("La cantidad total supera el stock disponible. Stock: " + stock);
                            return;
                        }

                        // Actualizamos la cantidad y el subtotal en la misma fila existente
                        fila.Cells["cantidad"].Value = nuevaCantidadTotal;
                        fila.Cells["subtotal"].Value = (nuevaCantidadTotal * precio).ToString(); // O con formato decimal si tu columna es numérica

                        productoEnGrilla = true;
                        break;
                    }
                }
            }

            // Si el producto NO estaba en la grilla, lo agregamos normalmente como una fila nueva
            if (!productoEnGrilla)
            {
                Entidades.DetalleVenta detalle = new Entidades.DetalleVenta();

                detalle.id_detalle_Venta = _nextDetalleId.ToString();
                detalle.nombre_producto = producto.nombre;
                detalle.cantidad = cantidad.ToString();
                detalle.precio_unitario = precio.ToString();
                detalle.subtotal = (precio * cantidad).ToString();
                detalle.descuento_aplicado = "0";
                detalle.id_producto = producto.id_producto;

                // AQUÍ AGREGAS LA FILA A TU DATAGRIDVIEW 
                // (Asegúrate de usar los nombres de tus columnas reales en el orden correcto)
                // Ejemplo:
                // dgvDetalle.Rows.Add(detalle.id_detalle_Venta, detalle.nombre_producto, detalle.precio_unitario, detalle.cantidad, detalle.subtotal);
            }
        }


        private void dgvDetalle_CellClick(object sender,
            DataGridViewCellEventArgs e)
            
        {
            if (e.RowIndex < 0)
                return;

            if (dgvDetalle.Columns["Quitar"] == null)
                return;

            if (e.ColumnIndex !=
                dgvDetalle.Columns["Quitar"].Index)
                return;

            string id =
                dgvDetalle.Rows[e.RowIndex]
                .Cells["IdDetalle"].Value.ToString();

            _detalle.RemoveAll(
                d => d.id_detalle_Venta == id);

            CargarDetalleGrilla();
            ActualizarTotales();
        }

        private void txtDescuento_TextChanged(
            object sender,
            EventArgs e)
        {
            ActualizarTotales();
        }

        private void txtImpuesto_TextChanged(
            object sender,
            EventArgs e)
        {
            ActualizarTotales();
        }

        private void btnRegistrar_Click(
            object sender,
            EventArgs e)
        {
            if (cmbCliente.SelectedItem == null ||
                cmbEmpleado.SelectedItem == null)
            {
                MessageBox.Show(
                    "Seleccione un cliente y un empleado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (_detalle.Count == 0)
            {
                MessageBox.Show(
                    "Agregue al menos un producto al detalle.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal descuento = 0;
            decimal impuesto = 0;

            decimal.TryParse(
                txtDescuento.Text,
                out descuento);

            decimal.TryParse(
                txtImpuesto.Text,
                out impuesto);

            decimal subtotal = 0;

            foreach (Entidades.DetalleVenta d in _detalle)
            {
                subtotal +=
                    Convert.ToDecimal(d.subtotal);
            }

            decimal montoDesc =
                subtotal * (descuento / 100);

            decimal montoImp =
                (subtotal - montoDesc) *
                (impuesto / 100);

            decimal total =
                subtotal - montoDesc + montoImp;


            Clientes cliente =
                (Clientes)cmbCliente.SelectedItem;

            Empleados empleado =
                (Empleados)cmbEmpleado.SelectedItem;


            string respuesta = NVenta.Agregar(
                dtpFecha.Value.ToString("yyyy-MM-dd"),
                total.ToString(),
                cmbMetodoPago.Text,
                montoImp.ToString(),
                montoDesc.ToString(),
                cliente.IdCliente.ToString(),
                empleado.id_Empleado
            );


            int idVenta;

            if (!int.TryParse(respuesta, out idVenta))
            {
                MessageBox.Show(
                    "No se pudo registrar la venta.\n" + respuesta,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            foreach (Entidades.DetalleVenta d in _detalle)
            {
                string respuestaDetalle =
                    NDetalleVenta.Agregar(
                        d.nombre_producto,
                        d.cantidad,
                        d.precio_unitario,
                        d.subtotal,
                        d.descuento_aplicado,
                        idVenta.ToString(),
                        d.id_producto
                    );

                if (respuestaDetalle != "OK")
                {
                    MessageBox.Show(
                        "La venta se registró, pero hubo un problema al registrar un detalle:\n"
                        + respuestaDetalle,
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }


            MessageBox.Show(
                "Venta #" + idVenta +
                " registrada correctamente.\nTotal: "
                + total.ToString("C2"),
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            Venta nuevaVenta = new Venta();

            nuevaVenta.fecha =
            dtpFecha.Value.ToString("yyyy-MM-dd");

            nuevaVenta.total =
            total.ToString();

            nuevaVenta.metodo_pago =
            cmbMetodoPago.Text;

            nuevaVenta.impuesto =
            montoImp.ToString();

            nuevaVenta.descuento =
             montoDesc.ToString();

            nuevaVenta.id_cliente =
            cliente.IdCliente.ToString();

            nuevaVenta.id_empleado =
            empleado.id_Empleado;

            string nombreCliente =
             cliente.Nombre;

            string nombreEmpleado =
             empleado.nombre;


            FrmDetalleVenta Factura =
             new FrmDetalleVenta(
                 nuevaVenta,
                 _detalle,
                 nombreCliente,
                 nombreEmpleado,
                 idVenta.ToString()

             );

            Factura.ShowDialog();


            Limpiar();
        }
        

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            Limpiar();
        }

        private void CargarDetalleGrilla()
        {
      
        
            dgvDetalle.Rows.Clear();

            foreach (var d in _detalle)
            {
                dgvDetalle.Rows.Add(
                    d.id_detalle_Venta,
                    d.nombre_producto,
                    d.precio_unitario,
                    d.cantidad,
                    d.subtotal
                );
            }
        }
                    
           
            
        

        private void ActualizarTotales()
        {
            decimal descuento = 0;
            decimal impuesto = 0;

            decimal.TryParse(
                txtDescuento.Text,
                out descuento);

            decimal.TryParse(
                txtImpuesto.Text,
                out impuesto);

            decimal subtotal = 0;

            foreach (Entidades.DetalleVenta d in _detalle)
            {
                subtotal +=
                    Convert.ToDecimal(d.subtotal);
            }

            decimal montoDesc =
                subtotal * (descuento / 100);

            decimal montoImp =
                (subtotal - montoDesc) *
                (impuesto / 100);

            decimal total =
                subtotal - montoDesc + montoImp;

            lblSubtotalVal.Text =
                subtotal.ToString("C2");

            lblDescuentoVal.Text =
                montoDesc.ToString("C2");

            lblImpuestoVal.Text =
                montoImp.ToString("C2");

            lblTotalVal.Text =
                total.ToString("C2");
        }

        private void EstilarGrilla()
        {
         
        
            dgvDetalle.EnableHeadersVisualStyles = false;

            dgvDetalle.RowsDefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(22, 160, 133);

            dgvDetalle.RowsDefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            dgvDetalle.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(22, 160, 133);

            dgvDetalle.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;
        }
        

        private void Limpiar()
        {
            _detalle.Clear();

            _nextDetalleId = 1;

            CargarDetalleGrilla();
            ActualizarTotales();
            CargarCombos();

            txtCantidad.Text = "1";

            txtDescuento.Enabled = true;
            txtDescuento.ReadOnly = false;
            txtDescuento.Text = "0";

            txtImpuesto.Text = "15";

            dtpFecha.Value = DateTime.Today;
        }

        private void cmbCliente_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void dgvDetalle_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void cmbProducto_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void cmbMetodoPago_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void lblEncabezado_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblDescuentoVal_Click(object sender, EventArgs e)
        {

        }

        private void lblImpuestoVal_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar(object sender, EventArgs e)
        {

        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {

        }


        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}