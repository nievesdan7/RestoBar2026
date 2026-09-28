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
    public partial class FRMProveedorRegistrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aprovee proveedor = new aprovee();
        private aperson persona = new aperson();

        public bool personaOK = false;
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codProMod = "";
        public bool actualizar = false;

        private String nombreMin = "Proveedor";
        private String nombreMay = "PROVEEDOR";
        #endregion

        #region Constructor
        public FRMProveedorRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (personaOK)
            {
                if (TXTRazonSocial.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Introduzca la Razón Social de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTRazonSocial.Focus();
                    respuesta = false;
                }
                else if (TXTNIT.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Introduzca el NIT de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTNIT.Focus();
                    respuesta = false;
                }
                else if (TXTNombreBanco.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Introduzca el Nombre de Banco de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTNombreBanco.Focus();
                    respuesta = false;
                }
                else if (TXTNumeroBanco.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Introduzca el Número de Cuenta de Banco de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTNumeroBanco.Focus();
                    respuesta = false;
                }
                else if (TXTNombreContacto.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Introduzca el Nombre de Contacto de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTNombreContacto.Focus();
                    respuesta = false;
                }
                else if (TXTTelefonoContacto.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Introduzca el Teléfono de Contacto de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTTelefonoContacto.Focus();
                    respuesta = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una persona", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LBLAgregarPersona.Focus();
                respuesta = false;
            }


            return respuesta;
        }
        private void LimpiarCasillas()
        {

            TXTTipoPersona.Text = "";
            TXTTipoDocumento.Text = "";
            TXTNumeroDocumento.Text = "";
            TXTNombres.Text = "";
            TXTApellidoPaterno.Text = "";
            TXTApellidoMaterno.Text = "";
            TXTDireccion.Text = "";
            TXTTelefono.Text = "";
            TXTCorreoElectronico.Text = "";

            SWBEstado.Value = false;
            TXTRazonSocial.Text = "";
            TXTNIT.Text = "";
            TXTNombreBanco.Text = "";
            TXTNumeroBanco.Text = "";
            TXTNombreContacto.Text = "";
            TXTTelefonoContacto.Text = "";

            TXTRazonSocial.Focus();
        }
        private void JalarDatos()
        {
            proveedor.papvcodpro = this.codProMod;
            proveedor.ObtenerDatos();

            persona.papscodper = proveedor.fapvcodper;
            persona.ObtenerDatos();

            TXTTipoPersona.Text = persona.capstipper;
            TXTTipoDocumento.Text = persona.capstipdoc;
            TXTNumeroDocumento.Text = persona.capsnumdoc;
            TXTNombres.Text = persona.capsnomper;
            TXTApellidoPaterno.Text = persona.capsapepat;
            TXTApellidoMaterno.Text = persona.capsapemat;
            TXTDireccion.Text = persona.capsdirper;
            TXTTelefono.Text = persona.capstelper;
            TXTCorreoElectronico.Text = persona.capscorele;

            SWBEstado.Value = proveedor.capvestpro;
            TXTRazonSocial.Text = proveedor.capvrazsoc;
            TXTNIT.Text = proveedor.capvnitpro;
            TXTNombreBanco.Text = proveedor.capvbannom;
            TXTNumeroBanco.Text = proveedor.capvnumcue;
            TXTNombreContacto.Text = proveedor.capvnomcon;
            TXTTelefonoContacto.Text = proveedor.capvtelcon;

        }
        #endregion

        #region Eventos
        private void FRMProveedorRegistrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar " + nombreMin;
                GPPanelProducto.Text = "Modificar " + nombreMin;
                TXTRazonSocial.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar " + nombreMin;
                GPPanelProducto.Text = "Registrar " + nombreMin;
                TXTRazonSocial.Focus();

            }
        }
        private void FRMProveedorRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void LBLAgregarPersona_MouseHover(object sender, EventArgs e)
        {
            LBLAgregarPersona.ForeColor = Color.LightCoral;
            LBLAgregarPersona.Font = new Font(LBLAgregarPersona.Font, FontStyle.Underline);
        }
        private void LBLAgregarPersona_Click(object sender, EventArgs e)
        {
            FRMPersonaBuscar a = new FRMPersonaBuscar();
            a.condicion = "papscodper not in (select papscodper from aperson,aprovee where papscodper=fapvcodper order by papscodper)";
            a.ShowDialog();
            if (a.seleccionadoOK)
            {
                this.persona = a.persona;
                this.personaOK = true;

                TXTTipoPersona.Text = persona.capstipper;
                TXTTipoDocumento.Text = persona.capstipdoc;
                TXTNumeroDocumento.Text = persona.capsnumdoc;
                TXTNombres.Text = persona.capsnomper;
                TXTApellidoPaterno.Text = persona.capsapepat;
                TXTApellidoMaterno.Text = persona.capsapemat;
                TXTDireccion.Text = persona.capsdirper;
                TXTTelefono.Text = persona.capstelper;
                TXTCorreoElectronico.Text = persona.capscorele;
            }
            else
            {
                this.personaOK = false;
                TXTTipoPersona.Text = "";
                TXTTipoDocumento.Text = "";
                TXTNumeroDocumento.Text = "";
                TXTNombres.Text = "";
                TXTApellidoPaterno.Text = "";
                TXTApellidoMaterno.Text = "";
                TXTDireccion.Text = "";
                TXTTelefono.Text = "";
                TXTCorreoElectronico.Text = "";

            }
        }
        private void LBLAgregarPersona_MouseLeave(object sender, EventArgs e)
        {
            LBLAgregarPersona.ForeColor = Color.OrangeRed;
            LBLAgregarPersona.Font = new Font(LBLAgregarPersona.Font, FontStyle.Regular);
        }
        private void SWBEstado_ValueChanged(object sender, EventArgs e)
        {
            if (SWBEstado.Value == true)
            {
                LBLEstado.Text = "Habilitado";
            }
            else
            {
                LBLEstado.Text = "Deshabilitado";
            }
        }

        private void BTNGrabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                proveedor = new aprovee();

                if (!this.modificar)
                {
                    correlativo.pxnctipcor = "aprovee";
                    if (correlativo.ObtenerSiguiente())
                    {
                        proveedor.papvcodpro = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D12");
                        proveedor.capvfeccre = DateTime.Now;

                    }
                    else
                    {
                        MessageBox.Show("No se obtuvo correlativo",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    proveedor.papvcodpro = this.codProMod;

                }

                proveedor.capvrazsoc = TXTRazonSocial.Text;
                proveedor.capvnitpro = TXTNIT.Text;
                proveedor.capvbannom = TXTNombreBanco.Text;
                proveedor.capvnumcue = TXTNumeroBanco.Text;
                proveedor.capvnomcon = TXTNombreContacto.Text;
                proveedor.capvtelcon = TXTTelefonoContacto.Text;
                proveedor.fapvcodper = persona.papscodper;

                if (!this.modificar)
                {
                    if (proveedor.Grabar())
                    {
                        MessageBox.Show("Éxito en el guardado de " + nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProveedorRegistrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en el guardado de " + nombreMay,
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (proveedor.Modificar())
                    {
                        MessageBox.Show("Éxito en la modificación de " + nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProveedorRegistrar_FormClosing;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la modificación de " + nombreMay,
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TXTNombreBanco_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            // 1. Letras de la A a la Z (sin Alt)
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            // 2. Espacio en blanco (sin Shift)
            else if (e.KeyCode == Keys.Space && !e.Shift)
                teclaValida = true;
            // 3. Teclas de control y navegación (Borrar, Suprimir, Flecha Izquierda, Flecha Derecha)
            else if ((e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) || //Punto (.) o Decimal (.)
                     (e.KeyCode == Keys.Back) ||
                     (e.KeyCode == Keys.Delete) ||
                     (e.KeyCode == Keys.Left) ||
                     (e.KeyCode == Keys.Right))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void TXTNIT_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false; // Identificar si es una tecla válida (correo electrónico)

            // 1. Letras de la A a la Z (sin Alt)
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;

            // 2. Números del teclado principal (0 al 9, sin Shift)
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;

            // 3. Números del teclado numérico (NumPad 0 al 9)
            else if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;

            // 4. Caracteres permitidos: Punto (.), Guion bajo (_), Guion (-)
            else if ((e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) ||                  // Punto (.)
                     (e.KeyCode == Keys.OemMinus && e.Shift) ||                                      // Guion bajo (_)
                     (e.KeyCode == Keys.OemMinus && !e.Shift) || (e.KeyCode == Keys.Subtract))       // Guion (-)
                teclaValida = true;

            // 5. Teclas de control y navegación (Borrar, Suprimir, Flecha Izquierda, Flecha Derecha)
            else if ((e.KeyCode == Keys.Back) ||
                     (e.KeyCode == Keys.Delete) ||
                     (e.KeyCode == Keys.Left) ||
                     (e.KeyCode == Keys.Right))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }

        }
        private void TXTNumeroBanco_KeyDown(object sender, KeyEventArgs e)
        {

            bool teclaValida = false; // Identificar si es una tecla válida (solo números)

            // 1. Números del teclado numérico (NumPad 0 al 9)
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            // 2. Números de la fila superior (0 al 9, asegurando que no se presione Shift para evitar símbolos como !, @, #, etc.)
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            // 3. Teclas de control y navegación (Borrar, Suprimir, Flecha Izquierda, Flecha Derecha)
            else if ((e.KeyCode == Keys.Back) ||
                     (e.KeyCode == Keys.Delete) ||
                     (e.KeyCode == Keys.Left) ||
                     (e.KeyCode == Keys.Right))
                teclaValida = true;

            if (!teclaValida)
            {
                e.SuppressKeyPress = true;
            }
        }
        #endregion
    }

}
