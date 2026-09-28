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
    public partial class FRMPersonaLista : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aperson persona = new aperson();
        private List<aperson> lista_personas = new List<aperson>();
        private string nombreMin = "Persona";
        private string nombreMay = "PERSONA";
        #endregion

        #region Constructor
        public FRMPersonaLista()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_personas.Clear();

            lista_personas = persona.Lista("(capsnomper like '%" + TXTFiltrar.Text + "%') limit " +
                                           IIN_Filas.Value.ToString()
                                           );
            foreach (aperson a in lista_personas)
            {
                DTGLista.Rows.Add();

                if (!a.capsestper)
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                }

                DTGLista[0, DTGLista.Rows.Count - 1].Value = a.papscodper;
                DTGLista[1, DTGLista.Rows.Count - 1].Value = a.capsestper;
                DTGLista[2, DTGLista.Rows.Count - 1].Value = a.capstipper;
                DTGLista[3, DTGLista.Rows.Count - 1].Value = a.capstipdoc;
                DTGLista[4, DTGLista.Rows.Count - 1].Value = a.capsnumdoc;
                DTGLista[5, DTGLista.Rows.Count - 1].Value = a.capsnomper;
                DTGLista[6, DTGLista.Rows.Count - 1].Value = a.capsapepat;
                DTGLista[7, DTGLista.Rows.Count - 1].Value = a.capsapemat;
                DTGLista[8, DTGLista.Rows.Count - 1].Value = a.capsdirper;
                DTGLista[9, DTGLista.Rows.Count - 1].Value = a.capstelper;
                DTGLista[10, DTGLista.Rows.Count - 1].Value = a.capscorele;
            
            }

        }
        #endregion

        #region Eventos
        private void FRMPersonaLista_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void BTN_Registrar_Click(object sender, EventArgs e)
        {
            FRMPersonaRegistrar a = new FRMPersonaRegistrar();
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
                FRMPersonaRegistrar a = new FRMPersonaRegistrar();
                a.modificar = true;
                a.codPerMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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
                FRMPersonaRegistrar F1 = new FRMPersonaRegistrar();
                F1.modificar = true;
                F1.codPerMod = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
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
                persona.papscodper = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    persona.capsestper = false;
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona inhabilitada");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    persona.capsestper = true;
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Persona habilitada");
                        ActualizarGrid();
                    }
                }
            }
        }
        private void CMSMenu_Opening(object sender, CancelEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTGLista.SelectedRows[0].Cells[0].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    if (persona.capsestper)
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
                    FRMPersonaRegistrar F1 = new FRMPersonaRegistrar();
                    F1.modificar = true;
                    F1.codPerMod = DTGLista[0, e.RowIndex].Value.ToString();
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
