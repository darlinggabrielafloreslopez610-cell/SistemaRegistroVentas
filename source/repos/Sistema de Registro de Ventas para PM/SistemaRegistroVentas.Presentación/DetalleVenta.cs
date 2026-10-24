using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaRegistroVentas.Entidades;

namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmDetalleVenta : Form
    {
        public Venta venta;
        public List<DetalleVenta> detalles;
        public string nombreCliente;
        public string nombreEmpleado;
        public string numeroFactura;

        public FrmDetalleVenta(
            Venta venta,
            List<DetalleVenta> detalles,
            string nombreCliente,
            string nombreEmpleado,
            string numeroFactura)
        {
            InitializeComponent();
            ConfigurarColumnas();

            this.venta = venta;
            this.detalles = detalles;
            this.nombreCliente = nombreCliente;
            this.nombreEmpleado = nombreEmpleado;
            this.numeroFactura = numeroFactura;
            this.Load += FrmDetalleVenta_Load;
            this.numeroFactura = numeroFactura;
         }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {


            {
                if (venta == null)
                    return;

                txtCliente.Text = nombreCliente;
                txtEmpleado.Text = nombreEmpleado;
                txtMetodoPago.Text = venta.metodo_pago;
                txtFecha.Text = venta.fecha;
                txtFactura.Text = numeroFactura;

                dgvProductos.Rows.Clear();

                foreach (DetalleVenta detalle in detalles)
                {
                    dgvProductos.Rows.Add(
                        detalle.id_producto,
                        detalle.nombre_producto,
                        detalle.cantidad,
                        detalle.precio_unitario,
                        detalle.subtotal
                    );
                }

                decimal subtotal = 0;

                foreach (DetalleVenta detalle in detalles)
                {
                    subtotal += Convert.ToDecimal(detalle.subtotal);
                }

                decimal descuento = Convert.ToDecimal(venta.descuento);
                decimal impuesto = Convert.ToDecimal(venta.impuesto);
                decimal total = Convert.ToDecimal(venta.total);

                lbls.Text = "$" + subtotal.ToString("0.00");
                lbl.Text = "$" + descuento.ToString("0.00");
                lblim.Text = "$" + impuesto.ToString("0.00");
                lbltot.Text = "$" + total.ToString("0.00");
            }
        }



        private void ConfigurarColumnas()
            

        {    dgvProductos.Columns.Clear();

              dgvProductos.Columns.Add("Codigo", "Código");
              dgvProductos.Columns.Add("Producto", "Producto");
              dgvProductos.Columns.Add("Cantidad", "Cantidad");
             dgvProductos.Columns.Add("PrecioUnitario", "Precio Unit.");
             dgvProductos.Columns.Add("Subtotal", "Subtotal");

             dgvProductos.Columns["Codigo"].Width = 50;
             dgvProductos.Columns["Producto"].Width = 140;
             dgvProductos.Columns["Cantidad"].Width = 60;
             dgvProductos.Columns["PrecioUnitario"].Width = 85;
             dgvProductos.Columns["Subtotal"].Width = 85;

             dgvProductos.ReadOnly = true;
             dgvProductos.AllowUserToAddRows = false;
             dgvProductos.AllowUserToDeleteRows = false;
             dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
             dgvProductos.MultiSelect = false;
        }

    }


    

}