using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el Nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre Completo' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // 2. Validar que el Salario no esté vacío
            if (string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("El campo 'Salario' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            // 3. Validar que el Salario sea un número válido
            decimal salario;
            if (!decimal.TryParse(txtSalario.Text.Trim(), out salario))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el salario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return;
            }

            // Si todo está correcto, muestra un mensaje de éxito
            MessageBox.Show("¡Empleado validado y listo para registrar!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos automáticamente después de guardar
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            dtpFechaContratacion.Value = DateTime.Now;
            txtNombre.Focus();
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            Menú menuPrincipal = new Menú();
            menuPrincipal.Show();
            this.Close();
        }
    }
    
}
          