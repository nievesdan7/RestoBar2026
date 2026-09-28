using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaRN;
namespace RestoBar2026
{
    public partial class FRMProductoLista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private lproduc producto = new lproduc();
        private aproduc producto2 = new aproduc();
        private List<lproduc> lista_productos = new List<lproduc>();
        private string nombreMin = "Producto";
        private string nombreMay = "PRODUCTO";
        #endregion

        #region Constructor
        public FRMProductoLista()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_productos.Clear();

            lista_productos = producto.Lista("(capdcodbar like '%" + TXTFiltrar.Text + "%' or " +                                             
                                             "capdnompro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capddespro like '%" + TXTFiltrar.Text + "%' or " +
                                             "cacpnomcat like '%" + TXTFiltrar.Text + "%') limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (lproduc a in lista_productos)
            {
                DTGLista.Rows.Add();

                if (!a.capdestpro)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papdcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capdestpro;               
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capdcodbar;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capdnompro;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.cacpnomcat;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capdconinv;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capdstopro;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.capdpreven;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.capdmarpro;
                DTGLista[9, DTGLista.Rows.Count - 1].Value = a.capdvolpro;
                DTGLista[10, DTGLista.Rows.Count - 1].Value = a.capdunimed;
                DTGLista[11, DTGLista.Rows.Count - 1].Value = a.capddespro;


            }

        }
        #endregion

        #region Eventos
        private void FRMProductoLista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMProductoRegistrar a = new FRMProductoRegistrar();
            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProductoRegistrar a = new FRMProductoRegistrar();
                a.modificar = true;
                a.codProMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                a.ShowDialog();
                if (a.actualizar)
                {
                    ActualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("No hay elementos en la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BTN_Reporte_Click(object sender, EventArgs e)
        {

        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProductoRegistrar F1 = new FRMProductoRegistrar();
                F1.modificar = true;
                F1.codProMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }
        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                producto2.papdcodpro = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (producto2.ObtenerDatos())
                {
                    producto2.capdestpro = false;
                    if (producto2.Modificar())
                    {
                        MessageBox.Show("Producto inhabilitado");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                producto2.papdcodpro = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (producto2.ObtenerDatos())
                {
                    producto2.capdestpro = true;
                    if (producto2.Modificar())
                    {
                        MessageBox.Show("Producto habilitado");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                producto2.papdcodpro = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (producto2.ObtenerDatos())
                {
                    if (producto2.capdestpro)
                    {
                        CMSMenu.Items[1].Visible = true;
                        CMSMenu.Items[2].Visible = false;
                    }
                    else
                    {
                        CMSMenu.Items[1].Visible = false;
                        CMSMenu.Items[2].Visible = true;
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMProductoRegistrar F1 = new FRMProductoRegistrar();
                    F1.modificar = true;
                    F1.codProMod = DTGLista[0, e.RowIndex].Value.ToString();
                    F1.ShowDialog();
                    if (F1.actualizar)
                    {
                        ActualizarGrid();
                    }
                }
            }
        }
        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            aproduc producto = new aproduc();
            producto.papdcodpro = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
            if (producto.ObtenerDatos())
            {
                if (MessageBox.Show("¿Está seguro que desea borrar " + nombreMin + ":" + producto.capdnompro + "?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (producto.Eliminar())
                    {
                        MessageBox.Show("Éxito en la eliminación de " + nombreMin);
                        ActualizarGrid();
                    }
                }

            }
        }
        #endregion

    }
}
