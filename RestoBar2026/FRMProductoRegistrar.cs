using AForge.Video;
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
    public partial class FRMProductoRegistrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        private aproduc producto = new aproduc();
        private acatpro categoria = new acatpro();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codProMod = "";

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public bool actualizar = false;
        private bool TieneFoto = false;

        public Boolean lectorHabilitado = false;

        private String nombreMin = "Producto";
        private String nombreMay = "PRODUCTO";
        #endregion

        #region Constructor
        public FRMProductoRegistrar()
        {
            InitializeComponent();            
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;
            aproduc producto2 = new aproduc();
            producto2.capdcodbar = LBLCodigoBarras.Text;

            if (CMBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Elija una categoría", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBCategoria.Focus();
                respuesta = false;
            }
            else if (CMBNombreProducto.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMBNombreProducto.Focus();
                respuesta = false;
            }          
            else if (producto2.ObtenerDatosCodigo(modificar, producto.capdcodbar))
            {
                MessageBox.Show("El código de barras ya existe", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LBLCodigoBarras.Focus();
                respuesta = false;
            }
            else if (DINPrecioVenta.Value <= 0)
            {
                MessageBox.Show("Introduzca un precio mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DINPrecioVenta.Focus();
                respuesta = false;
            }
            else if (DINPrecioMinimo.Value <= 0)
            {
                MessageBox.Show("Introduzca un precio mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DINPrecioVenta.Focus();
                respuesta = false;
            }
            else if (DINPrecioMinimo.Value >= DINPrecioVenta.Value)
            {
                MessageBox.Show("El precio de venta debe ser mayor al precio mínimo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DINPrecioVenta.Focus();
                respuesta = false;
            }
            else if (TXTDescripcion.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca la descripción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTDescripcion.Focus();
                respuesta = false;
            }




            if (SWBTipo.Value == true)
            {
                if (CMBMarca.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Introduzca la marca", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CMBMarca.Focus();
                    respuesta = false;
                }
                else if (DINVolumen.Value <= 0)
                {
                    MessageBox.Show("Introduzca un volumen mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DINVolumen.Focus();
                    respuesta = false;
                }
                else if (CMBUnidadMedida.SelectedIndex == -1)
                {
                    MessageBox.Show("Elija una unidad de medida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CMBUnidadMedida.Focus();
                    respuesta = false;
                }
            }
                        
            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWBEstado.Value = true;
            SWBTipo.Value = true;
            CMBNombreProducto.Text = "";
            CMBCategoria.SelectedIndex = -1;

            TieneFoto = false;
            PCBFotografía.Image = Resources.icFlashDesactivado;
            PCBCamara.Image = Resources.icFlashDesactivado;
            
            LBLCodigoBarras.Text = "S/C";
            LBLCodigoBarras.BackColor = Color.OrangeRed;
            CMBMarca.Text = "";
            DINVolumen.Value = 0.00;
            CMBUnidadMedida.SelectedIndex=-1;

            INTStock.Value = 0;
            DINPrecioVenta.Value = 0.00;
            DINPrecioMinimo.Value = 0.00;

            TXTDescripcion.Text = "";
            
            CMBNombreProducto.Focus();
        }
        private void CargarCombo(String campo, ComboBox combo)
        {

            try
            {
                List<String> listaNombreProducto = producto.Combo(campo);
                combo.Items.Clear();
                combo.DisplayMember = campo;

                combo.DataSource = listaNombreProducto;
                combo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }




        }
        private void CargarComboCategorias()
        {
            List<acatpro> listaCategorias = categoria.Lista("cacpestcat = true order by cacpnomcat");
            
            CMBCategoria.DisplayMember = "cacpnomcat";
            CMBCategoria.ValueMember = "pacpcodcat";
            CMBCategoria.DataSource = listaCategorias;
            CMBCategoria.SelectedIndex = -1;


        }
        private void JalarDatos()
        {
            producto.papdcodpro = this.codProMod;
            producto.ObtenerDatos();

            SWBEstado.Value = producto.capdestpro;
            SWBTipo.Value = producto.capdconinv;
            CMBNombreProducto.Text = producto.capdnompro;
            CMBCategoria.SelectedValue = producto.fapdcodcat;

            if (producto.capdfotpro == " ")
            {
                TieneFoto = false;
                PCBFotografía.Image = Resources.icFlashDesactivado;
            }
            else
            {
                TieneFoto = true;
                PCBFotografía.Image = MetodosGenerales.ConvertBase64StringToImage(producto.capdfotpro);
            }

            if(SWBTipo.Value == true)
            {
                LBLCodigoBarras.Text = producto.capdcodbar;
                if (producto.capdcodbar != " ")
                {
                    LBLCodigoBarras.Text = "S/C";
                    LBLCodigoBarras.BackColor = Color.OrangeRed;
                }
                else
                {
                    LBLCodigoBarras.BackColor = Color.Chartreuse;
                }
                CMBMarca.Text = producto.capdmarpro;
                DINVolumen.Value = (double)producto.capdvolpro;
                CMBUnidadMedida.Text = producto.capdunimed;
            }
            else
            {
                CMBMarca.Text = "";
                DINVolumen.Value = 0.00;
                CMBUnidadMedida.SelectedIndex = -1;
            }

            INTStock.Value = producto.capdstopro;
            DINPrecioVenta.Value = (double)producto.capdpreven;
            DINPrecioMinimo.Value = (double)producto.capdpremin;

            TXTDescripcion.Text = producto.capddespro;            

        }
        #endregion

        #region Eventos
        private void FRMProductoRegistrar_Load(object sender, EventArgs e)
        {
            CargarComboCategorias();
            CargarCombo("capdnompro", CMBNombreProducto);
            CargarCombo("capdmarpro", CMBMarca);

            if (this.modificar)
            {
                JalarDatos();
                BTNGrabar.Text = "&Modificar";
                this.Text = "Modificar "+nombreMin;
                GPPanelProducto.Text = "Modificar "+nombreMin;
                CMBNombreProducto.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTNGrabar.Text = "&Guardar";
                this.Text = "Registrar " + nombreMin;
                GPPanelProducto.Text = "Registrar " + nombreMin;
                CMBNombreProducto.Focus();

            }
        }
        private void FRMProductoRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                                "Pregunta",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ApagarCamara();
            }
        }

        private void SWBTipo_ValueChanged(object sender, EventArgs e)
        {
            if (SWBTipo.Value == true)
            {
                GPBebida.Enabled = true;
            }
            else
            {
                GPBebida.Enabled = false;
            }
        }
        private void BTNCodigoBarras_Click(object sender, EventArgs e)
        {
            if (!lectorHabilitado)
            {
                lectorHabilitado = true;
                LBLCodigoBarras.Text = "LECTOR ACTIVO";
                LBLCodigoBarras.BackColor = Color.Blue;
            }
            else
            {
                if (LBLCodigoBarras.Text == "LECTOR ACTIVO")
                {
                    LBLCodigoBarras.Text = "S/C";
                    LBLCodigoBarras.BackColor = Color.OrangeRed;
                }
                else
                {
                    LBLCodigoBarras.BackColor = Color.Blue;
                }
                lectorHabilitado = false;
                CMBMarca.Focus();
            }
        }
        private void BTNCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (LBLCodigoBarras.Text == "LECTOR ACTIVO")
            {
                LBLCodigoBarras.Text = "" + e.KeyChar;
            }
            else
            {
                LBLCodigoBarras.Text += e.KeyChar;
            }

        }
        private void CMBCategoria_Enter(object sender, EventArgs e)
        {
            ComboBoxEx a = (ComboBoxEx)sender;
            a.SelectAll();
        }
        private void CMBNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        private void TXTDescripcion_Enter(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.SelectAll();
        }
        private void BTN_AgregarCategoria_Click(object sender, EventArgs e)
        {
            FRMCategoriaRegistrar a = new FRMCategoriaRegistrar();
            a.ShowDialog();
            CargarComboCategorias();
        }

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BTN_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                producto = new aproduc();

                if (!this.modificar)
                {
                    correlativo.pxnctipcor = "aproduc";
                    if (correlativo.ObtenerSiguiente())
                    {
                        producto.papdcodpro = correlativo.pxnctipcor + "-" + correlativo.cxncnumcor.ToString("D12");
                        /*
                        producto.capdpreven = 0.00m;
                        producto.capdpremin = 0.00m;
                        producto.capdfotpro = " ";*/
                        producto.capdfeccre = DateTime.Now;                        
                        producto.capdstopro = 0;
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
                    producto.papdcodpro = this.codProMod;

                }                             

                producto.capdestpro = SWBEstado.Value;
                producto.capdconinv = SWBTipo.Value;
                producto.capdnompro = CMBNombreProducto.Text;
                producto.fapdcodcat = CMBCategoria.SelectedValue.ToString();

                if (TieneFoto)
                {
                    producto.capdfotpro = MetodosGenerales.ConvertImageToBase64String(PCBFotografía.Image);
                }
                else
                {
                    producto.capdfotpro = " ";
                }

                if (SWBTipo.Value == true) {
                    producto.capdcodbar = LBLCodigoBarras.Text;
                    producto.capdmarpro = CMBMarca.Text;
                    producto.capdvolpro = (decimal)DINVolumen.Value;
                    producto.capdunimed = CMBUnidadMedida.Text;
                }
                else {
                    producto.capdcodbar = "S/C";
                    producto.capdmarpro = "S/M";
                    producto.capdvolpro = 0.00m;
                    producto.capdunimed = "S/uM";
                }

                producto.capdpreven = (decimal)DINPrecioVenta.Value;
                producto.capdpremin = (decimal)DINPrecioMinimo.Value;

                producto.capddespro = TXTDescripcion.Text;
                producto.capdfecmod = DateTime.Now;


                


                if (!this.modificar)
                {
                    if (producto.Grabar())
                    {
                        MessageBox.Show("Éxito en el guardado de "+nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProductoRegistrar_FormClosing;
                        ApagarCamara();
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
                    if (producto.Modificar())
                    {
                        MessageBox.Show("Éxito en la modificación de "+nombreMay,
                                        "Mensaje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpiarCasillas();
                        this.actualizar = true;
                        this.FormClosing -= FRMProductoRegistrar_FormClosing;
                        ApagarCamara();
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

        private void CMBNombreProducto_KeyDown(object sender, KeyEventArgs e)
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
        #endregion

        #region Metodos de la cámara
        private void DetectarCamaras()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor            
            FinalFrame = new VideoCaptureDevice();
        }
        private void IniciarCamara()
        {
            try
            {                
                FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
                FinalFrame.Start();
            }
            catch
            {
                MessageBox.Show("No se detectó ninguna cámara web en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
                                                                             // New Frame Event Args is an constructor of a class
        {
            PCBCamara.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap

        }
        private void ApagarCamara()
        {
            /*if (FinalFrame.IsRunning == true) FinalFrame.Stop();*/
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop(); // Opcional: espera a que libere los recursos
                FinalFrame = null;
            }
        }
        #endregion

        #region Eventos de la cámara     
        private void SWBCamara_ValueChanged(object sender, EventArgs e)
        {
            if(SWBCamara.Value == true)
            {
                DetectarCamaras();
                IniciarCamara();
                
            }
            else
            {
                ApagarCamara();
                PCBCamara.Image = Resources.icFlashDesactivado;
            }
        }
        private void BTN_AbrirFoto_Click(object sender, EventArgs e)
        {
            if (OFDElegirImagen.ShowDialog() == DialogResult.OK)
            {
                PCBFotografía.ImageLocation = OFDElegirImagen.FileName;
                TieneFoto = true;
            }
        }
        private void BTN_LimpiarFoto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea borrar la imagen?",
                           "Pregunta",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TieneFoto = false;
                PCBFotografía.Image = Resources.icFlashDesactivado;
            }
        }
        private void BTN_CapturarFoto_Click(object sender, EventArgs e)
        {
            PCBFotografía.Image = PCBCamara.Image;
            TieneFoto = true;
        }






        #endregion

        
    }
        
}
