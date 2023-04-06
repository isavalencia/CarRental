using Car.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class ConsultaAlquileres : Form
    {
        public ConsultaAlquileres()
        {
            InitializeComponent();
        }

        CDatosAlquiler datosAlquiler = new CDatosAlquiler();
        alquilere alquilere = new alquilere();
        private int id_alquiler;

        private void CargarGrid()
        {
            var Lst = datosAlquiler.Read();
            dgvCAlquileres.DataSource = Lst;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Administrador admin = new Administrador("nombre");
            admin.Show();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;

        private void panelTituloConsultaAlquiler_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void ConsultaAlquileres_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
