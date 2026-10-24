using System;
using System.Data;
using System.Windows.Forms;
using SistemaRegistroVentas.Negocio;


namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmProductos : Form
    {


        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
        
            ConfigurarGrid();
            CargarComboCategorias();
            CargarProductos();

        }

        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = NProducto.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)

        {
            if (!ValidarCampos(false))
                return;

            if (cboCategoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string respuesta = NProducto.Agregar(
                    txtNombre.Text.Trim(),
                    txtPrecio.Text.Trim(),
                    txtStock.Text.Trim(),
                    "" ,//


                    cboCategoria.SelectedValue.ToString()
                );

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Producto agregado con éxito.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        respuesta,
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(true))
                return;

            try
            {
                int id = int.Parse(txtCodigo.Text.Trim());

                string respuesta = NProducto.Modificar(
                    id,
                    txtNombre.Text.Trim(),
                    txtPrecio.Text.Trim(),
                    txtStock.Text.Trim(),
                    "", //
                    cboCategoria.SelectedValue.ToString()
                );

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Producto modificado correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        respuesta,
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)

        {
            if (!int.TryParse(txtCodigo.Text.Trim(), out int id))
            {
                MessageBox.Show(
                    "Seleccione un producto válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                string resultado = NProducto.Eliminar(id);

                if (resultado == "OK")
                {
                    MessageBox.Show(
                        "Producto eliminado correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        resultado,
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtCodigo.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtPrecio.Text = fila.Cells[2].Value.ToString();
                txtStock.Text = fila.Cells[3].Value.ToString();
         
                cboCategoria.Text = fila.Cells[5].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
           
            txtNombre.Focus();
        }

        private bool ValidarCampos(bool requiereId)
        {
            if (requiereId && !int.TryParse(txtCodigo.Text.Trim(), out _))
            {
                MessageBox.Show("Seleccione un producto válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El Nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out _))
            {
                MessageBox.Show("Ingrese un formato de Precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out _))
            {
                MessageBox.Show("Ingrese un Stock entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ConfigurarGrid()

        {
            dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProductos.MultiSelect = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;

            dgvProductos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id_producto",
                HeaderText = "Código",
                Name = "colCodigo"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombre",
                HeaderText = "Nombre",
                Name = "colNombre"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "precio",
                HeaderText = "Precio",
                Name = "colPrecio"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "stock",
                HeaderText = "Stock",
                Name = "colStock"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "fecha_vencimiento",
                HeaderText = "Fecha de Vencimiento",
                Name = "colFechaVencimiento"
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombre_categoria", 
                HeaderText = "Categoría",
                Name = "colCategoria"
            });
        }
        private void CargarComboCategorias()
        {
            try
            {
                DataTable dt = SistemaRegistroVentas.Negocio.NCategoria.Consultar();
                cboCategoria.DataSource = dt;
                cboCategoria.DisplayMember = "nombre_categoria";
                cboCategoria.ValueMember = "id_categoria";
                cboCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void grpLista_Enter(object sender, EventArgs e)
        {

        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }

        private void btnpdto_Click(object sender, EventArgs e)
        {

        }

        private void btnpdto_click(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }
    }
}

        


    




