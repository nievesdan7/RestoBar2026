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
    public partial class FRMEmpleadoLista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables        
        private aemplea empleado = new aemplea();
        private List<aemplea> lista_empleados = new List<aemplea>();
        private string nombreMin = "Empleado";
        private string nombreMay = "EMPLEADO";
        #endregion

        #region Constructor
        public FRMEmpleadoLista()
        {
            InitializeComponent();
        }
        #endregion
        
        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_empleados.Clear();

            lista_empleados = empleado.Lista("(caeltipemp like '%" + TXTFiltrar.Text + "%' or " +
                                             "caelfecing like '%" + TXTFiltrar.Text + "%' or " +
                                             "caelfecsal like '%" + TXTFiltrar.Text + "%' or " +
                                             "caelsalemp like '%" + TXTFiltrar.Text + "%') limit " +
                                               IIN_Filas.Value.ToString()
                                               );
            foreach (aemplea a in lista_empleados)
            {
                DTGLista.Rows.Add();

                if (!a.caelestemp)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.paelcodemp;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.caeltipemp;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.caelfecing;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.caelfecsal;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.caelsalemp;             

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
            FRMEmpleadoRegistrar a = new FRMEmpleadoRegistrar();
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
                FRMEmpleadoRegistrar a = new FRMEmpleadoRegistrar();
                a.modificar = true;
                a.codEmpMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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
                FRMEmpleadoRegistrar F1 = new FRMEmpleadoRegistrar();
                F1.modificar = true;
                F1.codEmpMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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
                empleado.paelcodemp = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (empleado.ObtenerDatos())
                {
                    empleado.caelestemp = false;
                    if (empleado.Modificar())
                    {
                        MessageBox.Show("Empleado inhabilitado");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                empleado.paelcodemp = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (empleado.ObtenerDatos())
                {
                    empleado.caelestemp = true;
                    if (empleado.Modificar())
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
                empleado.paelcodemp = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (empleado.ObtenerDatos())
                {
                    if (empleado.caelestemp)
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
                    FRMEmpleadoRegistrar F1 = new FRMEmpleadoRegistrar();
                    F1.modificar = true;
                    F1.codEmpMod = DTGLista[0, e.RowIndex].Value.ToString();
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

        }
        #endregion

       
    }
}
