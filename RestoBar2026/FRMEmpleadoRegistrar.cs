using AForge.Video.DirectShow;
using CapaRN;
using DevComponents.DotNetBar.Controls;
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
    public partial class FRMEmpleadoRegistrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aemplea empleado = new aemplea();
        private aperson persona = new aperson();

        public bool personaOK = false;
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codEmpMod = "";
        public bool actualizar = false;

        private String nombreMin = "Empleado";
        private String nombreMay = "EMPLEADO";
        #endregion

        #region Constructor
        public FRMEmpleadoRegistrar()
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
                if (CMBTipoEmpleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Elija un tipo de Empleado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CMBTipoEmpleado.Focus();
                    respuesta = false;
                }
                else if (DTIFechaIngreso.Value >= DateTime.Now)
                {
                    MessageBox.Show("La Fecha de Ingreso no puede ser menor a la fecha actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DTIFechaIngreso.Focus();
                    respuesta = false;
                }
                else if (DINSalario.Value <= 0)
                {
                    MessageBox.Show("Introduzca un Salario mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DINSalario.Focus();
                    respuesta = false;
                }

                if (modificar)
                {
                    if (DTIFechaSalida.Value <= DTIFechaIngreso.Value)
                    {
                        MessageBox.Show("La Fecha de Salida no puede ser menor a la fecha de Ingreso", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DTIFechaSalida.Focus();
                        respuesta = false;
                    }
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
            
            TXTTipoPersona.Text="";
            TXTTipoDocumento.Text = "";
            TXTNumeroDocumento.Text = "";
            TXTNombres.Text = "";
            TXTApellidoPaterno.Text = "";
            TXTApellidoMaterno.Text = "";
            TXTDireccion.Text = "";
            TXTTelefono.Text = "";
            TXTCorreoElectronico.Text = "";

            SWBEstado.Value = false;
            CMBTipoEmpleado.SelectedIndex = -1;
            DTIFechaIngreso.Value = DateTime.Now;
            DTIFechaSalida.Value = DateTime.Now;
            DINSalario.Value = 0.00;

            TXTTipoPersona.Focus();
        }                
        private void JalarDatos()
        {
            empleado.paelcodemp = this.codEmpMod;
            empleado.ObtenerDatos();

            persona.papscodper=empleado.faelcodper;
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

            SWBEstado.Value = empleado.caelestemp;
            CMBTipoEmpleado.SelectedValue = empleado.caeltipemp;
            DTIFechaIngreso.Value = empleado.caelfecing;
            DTIFechaSalida.Value = empleado.caelfecsal;
            DINSalario.Value = (Double)empleado.caelsalemp;

        }
        #endregion

        #region Eventos
        private void FRMEmpleadoRegistrar_Load(object sender, EventArgs e)
        {
            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar " + nombreMin;
                GPPanelProducto.Text = "Modificar " + nombreMin;
                TXTTipoPersona.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar " + nombreMin;
                GPPanelProducto.Text = "Registrar " + nombreMin;
                TXTTipoPersona.Focus();

            }
        }
        private void FRMEmpleadoRegistrar_FormClosing(object sender, FormClosingEventArgs e)
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
            a.condicion = "papscodper not in (select papscodper from aperson,aemplea where papscodper=faelcodper order by papscodper)";
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
                empleado = new aemplea();

                if (!this.modificar)
                {
                    correlativo.pxnctipcor = "aemplea";
                    if (correlativo.ObtenerSiguiente())
                    {
                        empleado.paelcodemp = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D12");                       
                        empleado.caelfeccre = DateTime.Now;
                       
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
                    empleado.paelcodemp = this.codEmpMod;

                }

                empleado.caelestemp = SWBEstado.Value;
                empleado.caeltipemp = CMBTipoEmpleado.SelectedValue.ToString();
                empleado.caelfecing = DTIFechaIngreso.Value;
                empleado.caelfecsal = DTIFechaSalida.Value;
                empleado.caelsalemp = (decimal)DINSalario.Value;
                empleado.caelfecmod = DateTime.Now;
                empleado.faelcodper = persona.papscodper;

                if (!this.modificar)
                {
                    if (empleado.Grabar())
                    {
                        MessageBox.Show("Éxito en el guardado de " + nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMEmpleadoRegistrar_FormClosing;                        
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
                    if (empleado.Modificar())
                    {
                        MessageBox.Show("Éxito en la modificación de " + nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMEmpleadoRegistrar_FormClosing;               
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

        //Este formulario no necesita el evento de KeyDown
        #endregion


    }
}
