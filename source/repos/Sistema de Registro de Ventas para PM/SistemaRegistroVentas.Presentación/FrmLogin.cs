using System;
using System.Windows.Forms;

namespace SistemaRegistroVentas.Presentación
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // La contraseña empieza oculta
            txtcontraseña.UseSystemPasswordChar = false;
            txtcontraseña.PasswordChar = '•';

            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Mostrar contraseña
                txtcontraseña.PasswordChar = '\0';
            }
            else
            {
                // Ocultar contraseña
                txtcontraseña.PasswordChar = '•';
            }
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Darling" &&
                txtcontraseña.Text == "1234")
            {
                MessageBox.Show(
                    "¡Bienvenido al sistema!",
                    "Acceso Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Menú frmMenú = new Menú();
                frmMenú.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Error de Acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtcontraseña.Clear();
                txtcontraseña.Focus();
            }
        }
    }
}