namespace RestoBar2026
{
    partial class FRMPersonaRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GPPanelProducto = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.GPPersona = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.CMBTipoDocumento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.CI = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.CMBTipoPersona = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.NATURAL = new DevComponents.Editors.ComboItem();
            this.EXTRANJERA = new DevComponents.Editors.ComboItem();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LBLEstado = new DevComponents.DotNetBar.LabelX();
            this.TXTCorreoElectronico = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNumeroDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTApellidoMaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTApellidoPaterno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTNombres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNGrabar = new DevComponents.DotNetBar.ButtonX();
            this.BLTAyuda = new DevComponents.DotNetBar.BalloonTip();
            this.GPPanelProducto.SuspendLayout();
            this.GPPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPPanelProducto
            // 
            this.GPPanelProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.GPPanelProducto.CanvasColor = System.Drawing.Color.Transparent;
            this.GPPanelProducto.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GPPanelProducto.Controls.Add(this.GPPersona);
            this.GPPanelProducto.Controls.Add(this.BTNSalir);
            this.GPPanelProducto.Controls.Add(this.BTNLimpiar);
            this.GPPanelProducto.Controls.Add(this.BTNGrabar);
            this.GPPanelProducto.DisabledBackColor = System.Drawing.Color.Empty;
            this.GPPanelProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPPanelProducto.Location = new System.Drawing.Point(0, 0);
            this.GPPanelProducto.Name = "GPPanelProducto";
            this.GPPanelProducto.Size = new System.Drawing.Size(410, 259);
            // 
            // 
            // 
            this.GPPanelProducto.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GPPanelProducto.Style.BackColorGradientAngle = 90;
            this.GPPanelProducto.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GPPanelProducto.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelProducto.Style.BorderBottomWidth = 1;
            this.GPPanelProducto.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GPPanelProducto.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelProducto.Style.BorderLeftWidth = 1;
            this.GPPanelProducto.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelProducto.Style.BorderRightWidth = 1;
            this.GPPanelProducto.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelProducto.Style.BorderTopWidth = 1;
            this.GPPanelProducto.Style.CornerDiameter = 4;
            this.GPPanelProducto.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GPPanelProducto.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GPPanelProducto.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GPPanelProducto.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GPPanelProducto.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GPPanelProducto.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GPPanelProducto.TabIndex = 2;
            this.GPPanelProducto.Text = "Persona";
            // 
            // GPPersona
            // 
            this.GPPersona.BackColor = System.Drawing.Color.Gainsboro;
            this.GPPersona.CanvasColor = System.Drawing.Color.Black;
            this.GPPersona.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GPPersona.Controls.Add(this.CMBTipoDocumento);
            this.GPPersona.Controls.Add(this.CMBTipoPersona);
            this.GPPersona.Controls.Add(this.SWBEstado);
            this.GPPersona.Controls.Add(this.LBLEstado);
            this.GPPersona.Controls.Add(this.TXTCorreoElectronico);
            this.GPPersona.Controls.Add(this.TXTTelefono);
            this.GPPersona.Controls.Add(this.TXTNumeroDocumento);
            this.GPPersona.Controls.Add(this.TXTDireccion);
            this.GPPersona.Controls.Add(this.TXTApellidoMaterno);
            this.GPPersona.Controls.Add(this.TXTApellidoPaterno);
            this.GPPersona.Controls.Add(this.TXTNombres);
            this.GPPersona.DisabledBackColor = System.Drawing.Color.Empty;
            this.GPPersona.Location = new System.Drawing.Point(9, 3);
            this.GPPersona.Name = "GPPersona";
            this.GPPersona.Size = new System.Drawing.Size(385, 174);
            // 
            // 
            // 
            this.GPPersona.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GPPersona.Style.BackColorGradientAngle = 90;
            this.GPPersona.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GPPersona.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPersona.Style.BorderBottomWidth = 1;
            this.GPPersona.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GPPersona.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPersona.Style.BorderLeftWidth = 1;
            this.GPPersona.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPersona.Style.BorderRightWidth = 1;
            this.GPPersona.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPersona.Style.BorderTopWidth = 1;
            this.GPPersona.Style.CornerDiameter = 4;
            this.GPPersona.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GPPersona.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GPPersona.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GPPersona.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GPPersona.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GPPersona.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GPPersona.TabIndex = 5;
            // 
            // CMBTipoDocumento
            // 
            this.BLTAyuda.SetBalloonCaption(this.CMBTipoDocumento, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.CMBTipoDocumento, "Tipo de Documento de Identidad de la Persona");
            this.CMBTipoDocumento.DisplayMember = "Text";
            this.CMBTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.CMBTipoDocumento.FormattingEnabled = true;
            this.CMBTipoDocumento.ItemHeight = 16;
            this.CMBTipoDocumento.Items.AddRange(new object[] {
            this.CI,
            this.comboItem4});
            this.CMBTipoDocumento.Location = new System.Drawing.Point(6, 51);
            this.CMBTipoDocumento.Name = "CMBTipoDocumento";
            this.CMBTipoDocumento.Size = new System.Drawing.Size(180, 22);
            this.CMBTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBTipoDocumento.TabIndex = 25;
            this.CMBTipoDocumento.WatermarkText = "Tipo de Documento";
            // 
            // CI
            // 
            this.CI.Text = "CI";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "PASAPORTE";
            // 
            // CMBTipoPersona
            // 
            this.BLTAyuda.SetBalloonCaption(this.CMBTipoPersona, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.CMBTipoPersona, "Tipo de Persona");
            this.CMBTipoPersona.DisplayMember = "Text";
            this.CMBTipoPersona.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBTipoPersona.ForeColor = System.Drawing.Color.Black;
            this.CMBTipoPersona.FormattingEnabled = true;
            this.CMBTipoPersona.ItemHeight = 16;
            this.CMBTipoPersona.Items.AddRange(new object[] {
            this.NATURAL,
            this.EXTRANJERA});
            this.CMBTipoPersona.Location = new System.Drawing.Point(6, 23);
            this.CMBTipoPersona.Name = "CMBTipoPersona";
            this.CMBTipoPersona.Size = new System.Drawing.Size(180, 22);
            this.CMBTipoPersona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBTipoPersona.TabIndex = 24;
            this.CMBTipoPersona.WatermarkText = "Tipo de Persona";
            // 
            // NATURAL
            // 
            this.NATURAL.Text = "NATURAL";
            this.NATURAL.Value = "";
            // 
            // EXTRANJERA
            // 
            this.EXTRANJERA.Text = "EXTRANJERA";
            this.EXTRANJERA.Value = "";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.SWBEstado, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.SWBEstado, "Estado de la Persona");
            this.SWBEstado.Location = new System.Drawing.Point(192, 3);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.OrangeRed;
            this.SWBEstado.OffText = "";
            this.SWBEstado.OffTextColor = System.Drawing.Color.DarkGoldenrod;
            this.SWBEstado.OnBackColor = System.Drawing.Color.Blue;
            this.SWBEstado.OnText = "";
            this.SWBEstado.OnTextColor = System.Drawing.Color.Aqua;
            this.SWBEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SWBEstado.Size = new System.Drawing.Size(57, 14);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.SwitchBackColor = System.Drawing.Color.Silver;
            this.SWBEstado.SwitchBorderColor = System.Drawing.Color.Silver;
            this.SWBEstado.TabIndex = 23;
            this.SWBEstado.ValueChanged += new System.EventHandler(this.SWBEstado_ValueChanged);
            // 
            // LBLEstado
            // 
            this.LBLEstado.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LBLEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LBLEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEstado.ForeColor = System.Drawing.Color.Black;
            this.LBLEstado.Location = new System.Drawing.Point(116, 3);
            this.LBLEstado.Name = "LBLEstado";
            this.LBLEstado.Size = new System.Drawing.Size(70, 14);
            this.LBLEstado.TabIndex = 22;
            this.LBLEstado.Text = "Deshabilitado";
            // 
            // TXTCorreoElectronico
            // 
            this.TXTCorreoElectronico.BackColor = System.Drawing.Color.White;
            this.BLTAyuda.SetBalloonCaption(this.TXTCorreoElectronico, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTCorreoElectronico, "Correo Electrónico de la Persona");
            // 
            // 
            // 
            this.TXTCorreoElectronico.Border.Class = "TextBoxBorder";
            this.TXTCorreoElectronico.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCorreoElectronico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTCorreoElectronico.DisabledBackColor = System.Drawing.Color.White;
            this.TXTCorreoElectronico.ForeColor = System.Drawing.Color.Black;
            this.TXTCorreoElectronico.Location = new System.Drawing.Point(192, 136);
            this.TXTCorreoElectronico.Multiline = true;
            this.TXTCorreoElectronico.Name = "TXTCorreoElectronico";
            this.TXTCorreoElectronico.PreventEnterBeep = true;
            this.TXTCorreoElectronico.Size = new System.Drawing.Size(180, 23);
            this.TXTCorreoElectronico.TabIndex = 18;
            this.TXTCorreoElectronico.WatermarkText = "Correo Electrónico";
            this.TXTCorreoElectronico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTCorreoElectronico_KeyDown);
            // 
            // TXTTelefono
            // 
            this.TXTTelefono.BackColor = System.Drawing.Color.White;
            this.BLTAyuda.SetBalloonCaption(this.TXTTelefono, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTTelefono, "Número de Teléfono de la Persona");
            // 
            // 
            // 
            this.TXTTelefono.Border.Class = "TextBoxBorder";
            this.TXTTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTTelefono.DisabledBackColor = System.Drawing.Color.White;
            this.TXTTelefono.ForeColor = System.Drawing.Color.Black;
            this.TXTTelefono.Location = new System.Drawing.Point(6, 136);
            this.TXTTelefono.Multiline = true;
            this.TXTTelefono.Name = "TXTTelefono";
            this.TXTTelefono.PreventEnterBeep = true;
            this.TXTTelefono.Size = new System.Drawing.Size(180, 23);
            this.TXTTelefono.TabIndex = 17;
            this.TXTTelefono.WatermarkText = "Teléfono";
            this.TXTTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTTelefono_KeyDown);
            // 
            // TXTNumeroDocumento
            // 
            this.TXTNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.BLTAyuda.SetBalloonCaption(this.TXTNumeroDocumento, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTNumeroDocumento, "Número de Documento de Identidad de la Persona");
            // 
            // 
            // 
            this.TXTNumeroDocumento.Border.Class = "TextBoxBorder";
            this.TXTNumeroDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNumeroDocumento.DisabledBackColor = System.Drawing.Color.White;
            this.TXTNumeroDocumento.ForeColor = System.Drawing.Color.Black;
            this.TXTNumeroDocumento.Location = new System.Drawing.Point(6, 79);
            this.TXTNumeroDocumento.Multiline = true;
            this.TXTNumeroDocumento.Name = "TXTNumeroDocumento";
            this.TXTNumeroDocumento.PreventEnterBeep = true;
            this.TXTNumeroDocumento.Size = new System.Drawing.Size(180, 23);
            this.TXTNumeroDocumento.TabIndex = 12;
            this.TXTNumeroDocumento.WatermarkText = "Número de Documento";
            this.TXTNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNumeroDocumento_KeyDown);
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.BackColor = System.Drawing.Color.White;
            this.BLTAyuda.SetBalloonCaption(this.TXTDireccion, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTDireccion, "Dirección del Domicilio de la Persona");
            // 
            // 
            // 
            this.TXTDireccion.Border.Class = "TextBoxBorder";
            this.TXTDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDireccion.DisabledBackColor = System.Drawing.Color.White;
            this.TXTDireccion.ForeColor = System.Drawing.Color.Black;
            this.TXTDireccion.Location = new System.Drawing.Point(6, 108);
            this.TXTDireccion.Multiline = true;
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.PreventEnterBeep = true;
            this.TXTDireccion.Size = new System.Drawing.Size(366, 22);
            this.TXTDireccion.TabIndex = 16;
            this.TXTDireccion.WatermarkText = "Dirección";
            this.TXTDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTDireccion_KeyDown);
            // 
            // TXTApellidoMaterno
            // 
            this.TXTApellidoMaterno.BackColor = System.Drawing.Color.White;
            this.BLTAyuda.SetBalloonCaption(this.TXTApellidoMaterno, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTApellidoMaterno, "Apellido Materno de la Persona");
            // 
            // 
            // 
            this.TXTApellidoMaterno.Border.Class = "TextBoxBorder";
            this.TXTApellidoMaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApellidoMaterno.DisabledBackColor = System.Drawing.Color.White;
            this.TXTApellidoMaterno.ForeColor = System.Drawing.Color.Black;
            this.TXTApellidoMaterno.Location = new System.Drawing.Point(192, 79);
            this.TXTApellidoMaterno.Multiline = true;
            this.TXTApellidoMaterno.Name = "TXTApellidoMaterno";
            this.TXTApellidoMaterno.PreventEnterBeep = true;
            this.TXTApellidoMaterno.Size = new System.Drawing.Size(180, 23);
            this.TXTApellidoMaterno.TabIndex = 15;
            this.TXTApellidoMaterno.WatermarkText = "Apellido Materno";
            this.TXTApellidoMaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombres_KeyDown);
            // 
            // TXTApellidoPaterno
            // 
            this.TXTApellidoPaterno.BackColor = System.Drawing.Color.White;
            this.BLTAyuda.SetBalloonCaption(this.TXTApellidoPaterno, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTApellidoPaterno, "Apellido Paterno de la Persona");
            // 
            // 
            // 
            this.TXTApellidoPaterno.Border.Class = "TextBoxBorder";
            this.TXTApellidoPaterno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTApellidoPaterno.DisabledBackColor = System.Drawing.Color.White;
            this.TXTApellidoPaterno.ForeColor = System.Drawing.Color.Black;
            this.TXTApellidoPaterno.Location = new System.Drawing.Point(192, 51);
            this.TXTApellidoPaterno.Multiline = true;
            this.TXTApellidoPaterno.Name = "TXTApellidoPaterno";
            this.TXTApellidoPaterno.PreventEnterBeep = true;
            this.TXTApellidoPaterno.Size = new System.Drawing.Size(180, 22);
            this.TXTApellidoPaterno.TabIndex = 14;
            this.TXTApellidoPaterno.WatermarkText = "Apellido Paterno";
            this.TXTApellidoPaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombres_KeyDown);
            // 
            // TXTNombres
            // 
            this.TXTNombres.BackColor = System.Drawing.Color.White;
            this.BLTAyuda.SetBalloonCaption(this.TXTNombres, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.TXTNombres, "Nombres de la Persona");
            // 
            // 
            // 
            this.TXTNombres.Border.Class = "TextBoxBorder";
            this.TXTNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombres.DisabledBackColor = System.Drawing.Color.White;
            this.TXTNombres.ForeColor = System.Drawing.Color.Black;
            this.TXTNombres.Location = new System.Drawing.Point(192, 23);
            this.TXTNombres.Multiline = true;
            this.TXTNombres.Name = "TXTNombres";
            this.TXTNombres.PreventEnterBeep = true;
            this.TXTNombres.Size = new System.Drawing.Size(180, 22);
            this.TXTNombres.TabIndex = 13;
            this.TXTNombres.WatermarkText = "Nombres";
            this.TXTNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNombres_KeyDown);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::RestoBar2026.Properties.Resources.icCancelarRedondo;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(269, 183);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(125, 44);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 11;
            this.BTNSalir.Text = "&Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::RestoBar2026.Properties.Resources.icLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(140, 183);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(123, 44);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 10;
            this.BTNLimpiar.Text = "&Limpiar";
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGrabar.Image = global::RestoBar2026.Properties.Resources.icGuardar;
            this.BTNGrabar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGrabar.Location = new System.Drawing.Point(9, 183);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(125, 44);
            this.BTNGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGrabar.TabIndex = 9;
            this.BTNGrabar.Text = "&Grabar";
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // FRMPersonaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 259);
            this.Controls.Add(this.GPPanelProducto);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMPersonaRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMPersonaRegistrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMPersonaRegistrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMPersonaRegistrar_Load);
            this.GPPanelProducto.ResumeLayout(false);
            this.GPPersona.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GPPanelProducto;
        private DevComponents.DotNetBar.Controls.GroupPanel GPPersona;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBTipoDocumento;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBTipoPersona;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.LabelX LBLEstado;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCorreoElectronico;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTTelefono;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNumeroDocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApellidoMaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApellidoPaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombres;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGrabar;
        private DevComponents.Editors.ComboItem CI;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem NATURAL;
        private DevComponents.Editors.ComboItem EXTRANJERA;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
    }
}