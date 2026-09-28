using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoBar2026
{
    public partial class FRMPrincipal : Form
    {

        public FRMPrincipal()
        {
            InitializeComponent();
        }

        

        private void BTN_Productos_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMProductoLista a = new FRMProductoLista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void BTNCategorias_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMCategoriaLista a = new FRMCategoriaLista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void BTNEmpleados_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMEmpleadoLista a = new FRMEmpleadoLista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void BTNPersonas_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMPersonaLista a = new FRMPersonaLista();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            a.Show();
        }

       
    }
}
