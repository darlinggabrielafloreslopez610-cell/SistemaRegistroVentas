using System;
using System.Data;
using System.Windows.Forms;
using SistemaRegistroVentas.Negocio;

namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void CargarProveedores()
        {
            try
            {

                dataGridView1.DataSource = NProveedores.Consultar();
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
         

            
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                string respuesta = NProveedores.Agregar(
                    txtnempresa.Text.Trim(),
                    txtdirección.Text.Trim(),
                    txtteléfono.Text.Trim(),
                    txtcorreo.Text.Trim(),
                    txtcédula.Text.Trim()
                );

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Proveedor agregado correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProveedores();
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
            if (!int.TryParse(txtcódigo.Text.Trim(), out int id))
            {
                MessageBox.Show(
                    "Seleccione un proveedor válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidarCampos())
                return;

            try
            {
                string respuesta = NProveedores.Modificar(
                    id.ToString(),
                    txtnempresa.Text.Trim(),
                    txtdirección.Text.Trim(),
                    txtteléfono.Text.Trim(),
                    txtcorreo.Text.Trim(),
                    txtcédula.Text.Trim()
                );

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Proveedor modificado correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProveedores();
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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            txtcódigo.Text = fila.Cells["id_proveedor"].Value?.ToString();
            txtnempresa.Text = fila.Cells["nombre_empresa"].Value?.ToString();
            txtdirección.Text = fila.Cells["direccion"].Value?.ToString();
            txtteléfono.Text = fila.Cells["telefono"].Value?.ToString();
            txtcorreo.Text = fila.Cells["correo_electronico"].Value?.ToString();
            txtcédula.Text = fila.Cells["cedula"].Value?.ToString();
        }

        private void LimpiarCampos()
        {
            txtcódigo.Clear();
            txtnempresa.Clear();
            txtdirección.Clear();
            txtteléfono.Clear();
            txtcorreo.Clear();
            txtcédula.Clear();

            txtnempresa.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtnempresa.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la empresa.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtnempresa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtdirección.Text))
            {
                MessageBox.Show(
                    "Ingrese la dirección.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtdirección.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtteléfono.Text))
            {
                MessageBox.Show(
                    "Ingrese el teléfono.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtteléfono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtcorreo.Text))
            {
                MessageBox.Show(
                    "Ingrese el correo electrónico.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtcorreo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtcédula.Text))
            {
                MessageBox.Show(
                    "Ingrese la cédula.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtcédula.Focus();
                return false;
            }

            return true;
        }

        private void ConfigurarGrid()
        {
            dataGridView1.Columns.Clear(); 
            dataGridView1.AutoGenerateColumns = false; 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id_proveedor",
                HeaderText = "Código",
                DataPropertyName = "id_proveedor"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nombre_empresa",
                HeaderText = "Nombre Empresa",
                DataPropertyName = "nombre_empresa"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "direccion",
                HeaderText = "Dirección",
                DataPropertyName = "direccion"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "telefono",
                HeaderText = "Teléfono",
                DataPropertyName = "telefono"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "correo_electronico",
                HeaderText = "Correo Electrónico",
                DataPropertyName = "correo_electronico"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "cedula",
                HeaderText = "Cédula",
                DataPropertyName = "cedula"
            });
        }
        

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcódigo.Text.Trim(), out int id))
            {
                MessageBox.Show(
                    "Seleccione un proveedor válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar este proveedor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                string respuesta = NProveedores.Eliminar(id);

                if (respuesta == "OK")
                {
                    MessageBox.Show(
                        "Proveedor eliminado correctamente.",
                        "Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProveedores();
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

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void FrmProveedores_Load_1(object sender, EventArgs e)
        {
            txtcódigo.ReadOnly = true;

            ConfigurarGrid();
            CargarProveedores();

        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }
    }
    
}