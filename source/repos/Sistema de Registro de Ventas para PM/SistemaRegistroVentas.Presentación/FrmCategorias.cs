using System;
using System.Data;
using System.Windows.Forms;
using SistemaRegistroVentas.Negocio;

namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();


             dgvcategorias.SelectionChanged +=
          dgvcategorias_SelectionChanged;

            ConfigurarGrid();
            CargarCategorias();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfigurarGrid()
        {
            
            dgvcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvcategorias.MultiSelect = false;
            dgvcategorias.ReadOnly = true;
            dgvcategorias.AllowUserToAddRows = false;
            dgvcategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcategorias.AutoGenerateColumns = false;
            dgvcategorias.ColumnHeadersVisible = true;

            dgvcategorias.Columns.Clear();

      
            dgvcategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id_categoria",
                HeaderText = "Código",
                Name = "colCodigo"
            });

            dgvcategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombre_categoria",
                HeaderText = "Nombre de Categoría",
                Name = "colNombre"
            });

            dgvcategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "descripcion",
                HeaderText = "Descripción",
                Name = "colDescripcion"
            });
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable dt = NCategoria.Consultar();

                
                if (dt == null || dt.Columns.Count == 0)
                {
                    dt = new DataTable();
                    dt.Columns.Add("id_categoria", typeof(int));
                    dt.Columns.Add("nombre_categoria", typeof(string));
                    dt.Columns.Add("descripcion", typeof(string));
                }

                dgvcategorias.DataSource = dt;
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

        private void dgvcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvcategorias.Rows[e.RowIndex];

                txtcodigo.Text =
                    fila.Cells["colCodigo"].Value?.ToString();

                txtnombrecategoria.Text =
                    fila.Cells["colNombre"].Value?.ToString();

                txtdescripción.Text =
                    fila.Cells["colDescripcion"].Value?.ToString();
            }
        }

        private void dgvcategorias_SelectionChanged(object sender,EventArgs e)
        {
            if (dgvcategorias.SelectedRows.Count == 0)
                return;

            DataGridViewRow fila =
                dgvcategorias.SelectedRows[0];

            txtcodigo.Text =
                fila.Cells["colCodigo"].Value?.ToString() ?? "";

            txtnombrecategoria.Text =
                fila.Cells["colNombre"].Value?.ToString() ?? "";

            txtdescripción.Text =
                fila.Cells["colDescripcion"].Value?.ToString() ?? "";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombrecategoria.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la categoría.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                string respuesta = NCategoria.Agregar(
                    txtnombrecategoria.Text.Trim(),
                    txtdescripción.Text.Trim()
                );

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Categoría agregada correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCategorias();
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcodigo.Text.Trim(), out int id))
            {
                MessageBox.Show(
                    "Seleccione una categoría válida de la lista.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtnombrecategoria.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la categoría.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                string respuesta = NCategoria.Modificar(
                    id,
                    txtnombrecategoria.Text.Trim(),
                    txtdescripción.Text.Trim()
                );

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Categoría modificada correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCategorias();
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
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcodigo.Text.Trim(), out int id))
            {
                MessageBox.Show(
                    "Seleccione una categoría válida de la lista.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirmar = MessageBox.Show(
                "¿Está seguro de eliminar esta categoría?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            try
            {
                string respuesta = NCategoria.Eliminar(id);

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Categoría eliminada correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCategorias();
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

    
        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtcodigo.Clear();
            txtnombrecategoria.Clear();
            txtdescripción.Clear();

            txtnombrecategoria.Focus();

            dgvcategorias.ClearSelection();
        }

        private void dgvcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btncategorias_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }
    }
    
}