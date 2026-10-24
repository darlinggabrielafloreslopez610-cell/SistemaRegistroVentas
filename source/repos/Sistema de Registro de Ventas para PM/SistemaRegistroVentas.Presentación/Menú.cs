using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistroVentas.Presentación
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            FrmCompras frmcompras = new FrmCompras();
            frmcompras.Show();
            this.Hide();
        
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            FrmVentas frmventas = new FrmVentas();
            frmventas.Show();
            this.Hide();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmproductos = new FrmProductos();
            frmproductos.Show();
            this.Hide();
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frmcategorias = new FrmCategorias();
            frmcategorias.Show();
            this.Hide();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.Show();
            this.Hide();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frmproveedores = new FrmProveedores();
            frmproveedores.Show();
            this.Hide();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.Show();
            this.Hide();
        }

        

        
    }
    
}
