using CapaRN;
using RestoBar2026.Properties;
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
    public partial class FRMCategoriaRegistrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private xnumcor correlativo = new xnumcor();
        private acatpro tabla = new acatpro();
        public String codTabMod = "";

        public bool modificar = false;
        public bool actualizar = false;

        private String nombreMin = "Categoría";
        private String nombreMay = "CATEGORÍA";
        #endregion

        #region Constructor
        public FRMCategoriaRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXTNombreCategoria.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre de " + nombreMay, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombreCategoria.Focus();
                respuesta = false;
            }

            acatpro tabla2 = new acatpro();
            tabla2.cacpnomcat = TXTNombreCategoria.Text;

            if (tabla2.ObtenerDatosNombre(modificar, tabla.cacpnomcat))
            {
                MessageBox.Show("Ya existe una " + nombreMay + " con ese nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNombreCategoria.Focus();
                respuesta = false;
            }

            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            TXTNombreCategoria.Text = "";
        }
        private void JalarDatos()
        {
            tabla.pacpcodcat = this.codTabMod;
            tabla.ObtenerDatos();

            SWBEstado.Value = tabla.cacpestcat;
            TXTNombreCategoria.Text = tabla.cacpnomcat;

        }
        #endregion

        #region Eventos
        private void BTNGrabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {

                tabla = new acatpro();

                if (!this.modificar)
                {
                    correlativo.pxnctipcor = "acatpro";

                    if (correlativo.ObtenerSiguiente())
                    {
                        tabla.pacpcodcat = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D5");
                    }
                }
                else
                {
                    tabla.pacpcodcat = this.codTabMod;
                }
                tabla.cacpestcat = SWBEstado.Value;
                tabla.cacpnomcat = TXTNombreCategoria.Text.Trim();



                if (!this.modificar)
                {
                    if (tabla.Grabar())
                    {
                        MessageBox.Show("Éxito en el guardado de "+nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en el guardado de "+nombreMay,
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (tabla.Modificar())
                    {
                        MessageBox.Show("Éxito en la modificacìón de "+nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en el modificación de "+nombreMay,
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }

            }
        }
        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FRMCategoriaRegistrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar "+nombreMin;
                GPPanelCategoria.Text = "Modificar " + nombreMin;
                TXTNombreCategoria.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Agregar";
                BTNGrabar.Image = Resources.icAgregar;
                this.Text = "Registrar " + nombreMin;
                GPPanelCategoria.Text = "Registrar " + nombreMin;
                TXTNombreCategoria.Focus();
            }
        }
        #endregion

        
    }
}
