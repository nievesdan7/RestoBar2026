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
    public partial class FRMCategoriaLista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public acatpro categoria = new acatpro();
        private List<acatpro> lista = new List<acatpro>();
        public bool seleccionadoOK = false;
        private String nombreMin = "categoría";
        private String nombreMas = "Categoría";
        #endregion

        #region Constructor
        public FRMCategoriaLista()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista.Clear();

            lista = categoria.Lista("cacpnomcat like '%" + TXTFiltrar.Text + "%' limit " +
                                    IIN_Filas.Value.ToString()
                                    );
            foreach (acatpro a in lista)
            {
                DTGLista.Rows.Add();

                if (!a.cacpestcat)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }
                
                
                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.pacpcodcat;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.cacpestcat;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.cacpnomcat;
            }

        }
        #endregion

        #region Eventos
        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMCategoriaRegistrar a = new FRMCategoriaRegistrar();
            a.modificar = false;
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            FRMCategoriaRegistrar a = new FRMCategoriaRegistrar();
            a.modificar = true;
            a.codTabMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
        private void FRMCategoriaLista_Load(object sender, EventArgs e)
        {
            
            ActualizarGrid();
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                FRMCategoriaRegistrar F1 = new FRMCategoriaRegistrar();
                F1.modificar = true;
                F1.codTabMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                F1.ShowDialog();
                if (F1.actualizar)
                {
                    ActualizarGrid();
                }
            }
        }
        private void inhabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria.pacpcodcat = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                categoria.cacpestcat = false;
                if (categoria.Modificar())
                {
                    MessageBox.Show(nombreMas + " inhabilitada");
                    ActualizarGrid();
                }
            }
        }
        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria.pacpcodcat = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                categoria.cacpestcat = true;
                if (categoria.Modificar())
                {
                    MessageBox.Show(nombreMas + " habilitada");
                    ActualizarGrid();
                }
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria.pacpcodcat = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                if (MessageBox.Show("¿Está seguro que desea borrar la " + nombreMin + "?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (categoria.Eliminar())
                    {
                        MessageBox.Show(nombreMas + " eliminada");
                        ActualizarGrid();
                    }
                }

            }
        }
        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DTGLista.SelectedRows.Count > 0)
                {
                    FRMCategoriaRegistrar F1 = new FRMCategoriaRegistrar();
                    F1.modificar = true;
                    F1.codTabMod = DTGLista[0, e.RowIndex].Value.ToString();
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
            categoria.pacpcodcat = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
            if (categoria.ObtenerDatos())
            {
                if (MessageBox.Show("¿Está seguro que desea borrar la " + nombreMin + "?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (categoria.Eliminar())
                    {
                        MessageBox.Show(nombreMas + " eliminada");
                        ActualizarGrid();
                    }
                }

            }
        }
        #endregion

    }
}
