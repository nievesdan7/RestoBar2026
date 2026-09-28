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
    public partial class FRMPersonaBuscar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        public aperson persona = new aperson();
        private List<aperson> lista_personas = new List<aperson>();
        public bool seleccionadoOK = false;
        public String condicion = "";
        #endregion

        #region Constructor
        public FRMPersonaBuscar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void ActualizarGrid()
        {
            DTGLista.Rows.Clear();
            lista_personas.Clear();

            lista_personas = persona.Lista(condicion + " and (capstipper like '%" + TXTFiltrar.Text + "%' or " +
                                           "capstipdoc like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnumdoc like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapepat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsapemat like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsnomper like '%" + TXTFiltrar.Text + "%' or " +
                                           "capsdirper like '%" + TXTFiltrar.Text + "%' or " +
                                           "capstelper like '%" + TXTFiltrar.Text + "%' or " +

                                           "capscorele like '%" + TXTFiltrar.Text + "%') and capsestper = true " +
                                           " limit " +
                                           IINFilas.Value.ToString());
            foreach (aperson a in lista_personas)
            {
                DTGLista.Rows.Add();

                if (a.capsestper)
                {
                    if (DTGLista.Rows.Count % 2 == 0)
                    {
                        DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
                else
                {
                    DTGLista.Rows[DTGLista.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
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
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        private void TXTFiltrar_TextChanged(object sender, EventArgs e)
        {
            TXTFiltrar.SelectAll();
        }
        private void FRMPersonaBuscar_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        private void BTNAgregarPersona_Click(object sender, EventArgs e)
        {
            FRMPersonaRegistrar a = new FRMPersonaRegistrar();
            a.ShowDialog();
            if (a.actualizar)
            {
                ActualizarGrid();
            }
        }
        private void BTNElegirPersona_Click(object sender, EventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }
            }
        }
        private void DTGLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DTGLista.SelectedRows.Count > 0)
            {
                persona.papscodper = DTGLista[0, DTGLista.SelectedRows[0].Index].Value.ToString();
                if (persona.ObtenerDatos())
                {
                    seleccionadoOK = true;
                    this.Close();
                }

            }
        }
        #endregion


    }
}
