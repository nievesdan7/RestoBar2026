using CapaRN;
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
    public partial class FRMProveedorLista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables        
        private aprovee proveedor = new aprovee();
        private List<aprovee> lista_proveedores = new List<aprovee>();
        private string nombreMin = "Proveedor";
        private string nombreMay = "PROVEEDOR";
        #endregion

        #region Constructor
        public FRMProveedorLista()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_proveedores.Clear();

            lista_proveedores = proveedor.Lista("(capvrazsoc like '%" + TXTFiltrar.Text + "%' or " +
                                             "capvnitpro like '%" + TXTFiltrar.Text + "%' or " +
                                             "capvnomcon like '%" + TXTFiltrar.Text + "%' or " +
                                             "capvtelcon like '%" + TXTFiltrar.Text + "%') limit " +
                                               IINFilas.Value.ToString()
                                               );
            foreach (aprovee a in lista_proveedores)
            {
                DTGLista.Rows.Add();

                if (!a.capvestpro)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papvcodpro;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capvrazsoc;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capvnitpro;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capvbannom;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capvnumcue;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capvnomcon;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capvtelcon;

            }

        }
        #endregion

        #region Eventos
        private void FRMProveedorLista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMProveedorRegistrar a = new FRMProveedorRegistrar();
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
                FRMProveedorRegistrar a = new FRMProveedorRegistrar();
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
       
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMProveedorRegistrar F1 = new FRMProveedorRegistrar();
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
                proveedor.papvcodpro = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (proveedor.ObtenerDatos())
                {
                    proveedor.capvestpro = false;
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Proveedor inhabilitado");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                proveedor.papvcodpro = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (proveedor.ObtenerDatos())
                {
                    proveedor.capvestpro = true;
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Empleado habilitado");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                proveedor.papvcodpro = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (proveedor.ObtenerDatos())
                {
                    if (proveedor.capvestpro)
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
                    FRMProveedorRegistrar F1 = new FRMProveedorRegistrar();
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


        #endregion
        
    }
}
