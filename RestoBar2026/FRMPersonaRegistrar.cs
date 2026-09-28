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
    public partial class FRMPersonaRegistrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aperson persona = new aperson();

        public bool personaOK = false;
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codPerMod = "";
        public bool actualizar = false;

        private String nombreMin = "Persona";
        private String nombreMay = "PERSONA";
        #endregion

        #region Constructor
        public FRMPersonaRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (CMBTipoPersona.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un Tipo de "+nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBTipoPersona.Focus();
                respuesta = false;
            }
            else if (CMBTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un Tipo de Documento de "+nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBTipoDocumento.Focus();
                respuesta = false;
            }
            else if (TXTNumeroDocumento.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Número de Documento de "+nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNumeroDocumento.Focus();
                respuesta = false;
            }
            else if(TXTNombres.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Nombre de "+nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTNumeroDocumento.Focus();
                respuesta = false;
            }
            else if(TXTApellidoPaterno.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Apellido Paterno de "+nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTApellidoPaterno.Focus();
                respuesta = false;
            }
            else if(TXTApellidoMaterno.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Apellido Materno de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTApellidoMaterno.Focus();
                respuesta = false;
            }
            else if(TXTApellidoMaterno.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Apellido Materno de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTApellidoMaterno.Focus();
                respuesta = false;
            }
            else if (TXTDireccion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Dirección de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTDireccion.Focus();
                respuesta = false;
            }
            else if (TXTTelefono.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el teléfono de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTTelefono.Focus();
                respuesta = false;
            }
            else if (TXTCorreoElectronico.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el Correo Electrónico de " + nombreMin, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTCorreoElectronico.Focus();
                respuesta = false;
            }


            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWBEstado.Value = false;
            CMBTipoPersona.SelectedIndex = -1;
            CMBTipoDocumento.SelectedIndex = -1;
            TXTNumeroDocumento.Text = "";
            TXTNombres.Text = "";
            TXTApellidoPaterno.Text = "";
            TXTApellidoMaterno.Text = "";
            TXTDireccion.Text = "";
            TXTTelefono.Text = "";
            TXTCorreoElectronico.Text = "";

            CMBTipoPersona.Focus();
        }
        private void JalarDatos()
        {
            persona.papscodper = this.codPerMod;
            persona.ObtenerDatos();

            SWBEstado.Value = persona.capsestper;
            CMBTipoPersona.SelectedIndex = CMBTipoPersona.FindStringExact(persona.capstipper);
            CMBTipoDocumento.SelectedIndex = CMBTipoDocumento.FindStringExact(persona.capstipdoc);
            TXTNumeroDocumento.Text = persona.capsnumdoc;
            TXTNombres.Text = persona.capsnomper;
            TXTApellidoPaterno.Text = persona.capsapepat;
            TXTApellidoMaterno.Text = persona.capsapemat;
            TXTDireccion.Text = persona.capsdirper;
            TXTTelefono.Text = persona.capstelper;
            TXTCorreoElectronico.Text = persona.capscorele;           

        }
        #endregion

        #region Eventos
        private void FRMPersonaRegistrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar " + nombreMin;
                GPPanelProducto.Text = "Modificar " + nombreMin;
                CMBTipoPersona.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar " + nombreMin;
                GPPanelProducto.Text = "Registrar " + nombreMin;
                CMBTipoPersona.Focus();

            }
        }
        private void FRMPersonaRegistrar_FormClosing(object sender, FormClosingEventArgs e)
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
                persona = new aperson();

                if (!this.modificar)
                {
                    correlativo.pxnctipcor = "aperson";
                    if (correlativo.ObtenerSiguiente())
                    {
                        persona.papscodper = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D12");
                        persona.capsfeccre = DateTime.Now;

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
                    persona.papscodper = this.codPerMod;

                }

                persona.capsestper = SWBEstado.Value;
                persona.capstipper = CMBTipoPersona.Text;
                persona.capstipdoc = CMBTipoDocumento.Text;
                persona.capsnumdoc = TXTNumeroDocumento.Text;
                persona.capsnomper = TXTNombres.Text;
                persona.capsapepat = TXTApellidoPaterno.Text;
                persona.capsapemat = TXTApellidoMaterno.Text;
                persona.capsdirper = TXTDireccion.Text;
                persona.capstelper = TXTTelefono.Text;
                persona.capscorele = TXTCorreoElectronico.Text;

                persona.capsfecmod = DateTime.Now;

                if (!this.modificar)
                {
                    if (persona.Grabar())
                    {
                        MessageBox.Show("Éxito en el guardado de " + nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMPersonaRegistrar_FormClosing;
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
                    if (persona.Modificar())
                    {
                        MessageBox.Show("Éxito en la modificación de " + nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMPersonaRegistrar_FormClosing;
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
        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }   
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void TXTNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false; // Identificar si es una tecla válida (alfanumérico y guion)

            // 1. Números del teclado numérico (NumPad 0 al 9)
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;
            // 2. Números de la fila superior (0 al 9, sin Shift)
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;
            // 3. Letras de la A a la Z (sin Alt)
            else if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            // 4. Guion medio (teclado numérico y principal con o sin Shift según teclado) y teclas de navegación
            else if ((e.KeyCode == Keys.Subtract) ||
                     (e.KeyCode == Keys.OemMinus) ||
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
        private void TXTNombres_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false;

            // 1. Letras de la A a la Z (sin Alt)
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;
            // 2. Espacio en blanco (sin Shift)
            else if (e.KeyCode == Keys.Space && !e.Shift)
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
        private void TXTTelefono_KeyDown(object sender, KeyEventArgs e)
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
        private void TXTDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaValida = false; // Identificar si es una tecla válida (dirección)

            // 1. Letras de la A a la Z (sin Alt)
            if ((e.KeyCode >= Keys.A) && (e.KeyCode <= Keys.Z) && (!e.Alt))
                teclaValida = true;

            // 2. Números del teclado principal (0 al 9, sin Shift)
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                teclaValida = true;

            // 3. Números del teclado numérico (NumPad 0 al 9)
            else if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                teclaValida = true;

            // 4. Espacio en blanco
            else if (e.KeyCode == Keys.Space && !e.Shift)
                teclaValida = true;

            // 5. Signos comunes en direcciones: Guion (-), Numeral (#), Punto (.) y Coma (,)
            else if ((e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) || // Guion
                     (e.KeyCode == Keys.D3 && e.Shift) ||                         // Numeral (#)
                     (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) || // Punto (.)
                     (e.KeyCode == Keys.Oemcomma))                                // Coma (,)
                teclaValida = true;

            // 6. Teclas de control y navegación (Borrar, Suprimir, Flecha Izquierda, Flecha Derecha)
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
        private void TXTCorreoElectronico_KeyDown(object sender, KeyEventArgs e)
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

            // 4. Arroba (@) -> AltGr + Q o Shift + 2 en distribución de teclado español/latam
            else if ((e.KeyCode == Keys.Q && e.Alt) || (e.KeyCode == Keys.D2 && e.Shift))
                teclaValida = true;

            // 5. Caracteres permitidos: Punto (.), Guion bajo (_), Guion (-)
            else if ((e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) ||                  // Punto (.)
                     (e.KeyCode == Keys.OemMinus && e.Shift) ||                                      // Guion bajo (_)
                     (e.KeyCode == Keys.OemMinus && !e.Shift) || (e.KeyCode == Keys.Subtract))       // Guion (-)
                teclaValida = true;

            // 6. Teclas de control y navegación (Borrar, Suprimir, Flecha Izquierda, Flecha Derecha)
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
