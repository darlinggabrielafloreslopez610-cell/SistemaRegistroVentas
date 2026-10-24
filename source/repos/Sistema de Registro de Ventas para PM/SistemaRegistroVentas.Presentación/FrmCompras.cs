using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SistemaRegistroVentas.Entidades;
using SistemaRegistroVentas.Negocio;


namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmCompras : Form
    {
        private List<DetalleCompra> detalles = new List<DetalleCompra>();

        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            dtpFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblt.Text = "0.00";

            ConfigurarGrid();
            CargarProveedores();
            CargarProductos();
            CargarEmpleados();
        }

        private void ConfigurarGrid()
        {
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.MultiSelect = false;
            dgvDetalle.ReadOnly = true;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalle.Columns.Clear();
            dgvDetalle.Columns.Add("Producto", "Producto");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");
        }

        private void CargarProveedores()
        {
            try

            {
                cmbProveedor.DataSource = NProveedores.Consultar();
                cmbProveedor.ValueMember = "id_proveedor";
                cmbProveedor.DisplayMember = "nombre_empresa";
                cmbProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                cmbProducto.DataSource = NProducto.Consultar();
                cmbProducto.ValueMember = "id_producto";
                cmbProducto.DisplayMember = "nombre";
                cmbProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarEmpleadoDefault()
        {
            cmbEmpleado.Items.Clear();
            cmbEmpleado.Items.Add("Cajero General");
            cmbEmpleado.SelectedIndex = 0;
            cmbEmpleado.Enabled = false;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio de compra válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRowView fila = (DataRowView)cmbProducto.SelectedItem;
            string nombreProducto = fila["nombre"].ToString();
            int idProducto = Convert.ToInt32(fila["id_producto"]);

         
            decimal subtotal = cantidad * precio;

            DetalleCompra detalle = new DetalleCompra();
            detalle.id_producto = idProducto.ToString();
            detalle.nombre_producto = nombreProducto;
            detalle.cantidad_Compra = cantidad.ToString();
            detalle.id_detalle_Compra = cantidad.ToString();
            detalle.precio_unitario = precio.ToString();
            detalle.subtotal = subtotal.ToString();

            detalles.Add(detalle);

            dgvDetalle.Rows.Add(
                detalle.nombre_producto,
                detalle.cantidad_Compra,
                detalle.id_detalle_Compra,
                detalle.precio_unitario,
                detalle.subtotal
            );

            CalcularTotal();

            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            cmbProducto.SelectedIndex = -1;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DetalleCompra detalle in detalles)
            {
                total += Convert.ToDecimal(detalle.subtotal);
            }
            lblt.Text = total.ToString("0.00");
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            detalles.Clear();
            dgvDetalle.Rows.Clear();

            cmbProveedor.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;

            txtCantidad.Clear();
            txtPrecioCompra.Clear();

            dtpFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");

            lblt.Text = "0.00";
        }

        private void CargarEmpleados()
        {
            
              cmbEmpleado.Items.Clear();


              cmbEmpleado.Items.Add("Cajero General");
              cmbEmpleado.Items.Add("Administradora");

           
             cmbEmpleado.SelectedIndex = 0;
             cmbEmpleado.Enabled = true; 
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            {
                if (cmbProveedor.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbEmpleado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (detalles.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto a la compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {

                    string idProveedor = cmbProveedor.SelectedValue.ToString();


                    string idEmpleado = "1";

                    string respuesta = NCompra.Agregar(
                        dtpFecha.Text,
                        lblt.Text,
                        idEmpleado,
                        idProveedor
                    );

                    if (respuesta == "OK")
                    {
                        MessageBox.Show("Compra registrada correctamente.", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }
    }
    
            
}