namespace RestoBar2026
{
    partial class FRMEmpleadoRegistrar
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
            this.GPBebida = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.LBLEstado = new DevComponents.DotNetBar.LabelX();
            this.DINSalario = new DevComponents.Editors.DoubleInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.DTIFechaSalida = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.DTIFechaIngreso = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.CMBTipoEmpleado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.GPPersona = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TXTTipoDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXTTipoPersona = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LBLAgregarPersona = new DevComponents.DotNetBar.LabelX();
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
            this.GPBebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DINSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFechaSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFechaIngreso)).BeginInit();
            this.GPPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPPanelProducto
            // 
            this.GPPanelProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.GPPanelProducto.CanvasColor = System.Drawing.Color.Transparent;
            this.GPPanelProducto.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GPPanelProducto.Controls.Add(this.GPBebida);
            this.GPPanelProducto.Controls.Add(this.GPPersona);
            this.GPPanelProducto.Controls.Add(this.BTNSalir);
            this.GPPanelProducto.Controls.Add(this.BTNLimpiar);
            this.GPPanelProducto.Controls.Add(this.BTNGrabar);
            this.GPPanelProducto.DisabledBackColor = System.Drawing.Color.Empty;
            this.GPPanelProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPPanelProducto.Location = new System.Drawing.Point(0, 0);
            this.GPPanelProducto.Name = "GPPanelProducto";
            this.GPPanelProducto.Size = new System.Drawing.Size(410, 365);
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
            this.GPPanelProducto.TabIndex = 0;
            this.GPPanelProducto.Text = "Empleado";
            // 
            // GPBebida
            // 
            this.GPBebida.BackColor = System.Drawing.Color.Gainsboro;
            this.GPBebida.CanvasColor = System.Drawing.SystemColors.Control;
            this.GPBebida.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GPBebida.Controls.Add(this.SWBEstado);
            this.GPBebida.Controls.Add(this.LBLEstado);
            this.GPBebida.Controls.Add(this.DINSalario);
            this.GPBebida.Controls.Add(this.labelX5);
            this.GPBebida.Controls.Add(this.DTIFechaSalida);
            this.GPBebida.Controls.Add(this.DTIFechaIngreso);
            this.GPBebida.Controls.Add(this.CMBTipoEmpleado);
            this.GPBebida.DisabledBackColor = System.Drawing.Color.Empty;
            this.GPBebida.Location = new System.Drawing.Point(9, 188);
            this.GPBebida.Name = "GPBebida";
            this.GPBebida.Size = new System.Drawing.Size(385, 94);
            // 
            // 
            // 
            this.GPBebida.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GPBebida.Style.BackColorGradientAngle = 90;
            this.GPBebida.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GPBebida.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPBebida.Style.BorderBottomWidth = 1;
            this.GPBebida.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GPBebida.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPBebida.Style.BorderLeftWidth = 1;
            this.GPBebida.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPBebida.Style.BorderRightWidth = 1;
            this.GPBebida.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPBebida.Style.BorderTopWidth = 1;
            this.GPBebida.Style.CornerDiameter = 4;
            this.GPBebida.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GPBebida.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GPBebida.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GPBebida.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GPBebida.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GPBebida.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GPBebida.TabIndex = 1;
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.SWBEstado, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.SWBEstado, "Estado del Empleado");
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
            this.SWBEstado.TabIndex = 0;
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
            this.LBLEstado.TabIndex = 20;
            this.LBLEstado.Text = "Deshabilitado";
            // 
            // DINSalario
            // 
            // 
            // 
            // 
            this.DINSalario.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DINSalario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.DINSalario, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.DINSalario, "Salario del Empleado");
            this.DINSalario.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.DINSalario.Increment = 1D;
            this.DINSalario.InputMouseWheelEnabled = false;
            this.DINSalario.Location = new System.Drawing.Point(247, 51);
            this.DINSalario.Name = "DINSalario";
            this.DINSalario.ShowUpDown = true;
            this.DINSalario.Size = new System.Drawing.Size(125, 22);
            this.DINSalario.TabIndex = 4;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(192, 51);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(51, 22);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Salario:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // DTIFechaSalida
            // 
            // 
            // 
            // 
            this.DTIFechaSalida.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTIFechaSalida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.DTIFechaSalida, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.DTIFechaSalida, "Fecha de Salida de Empleado");
            this.DTIFechaSalida.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTIFechaSalida.ButtonDropDown.Visible = true;
            this.DTIFechaSalida.Enabled = false;
            this.DTIFechaSalida.IsPopupCalendarOpen = false;
            this.DTIFechaSalida.Location = new System.Drawing.Point(192, 23);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTIFechaSalida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFechaSalida.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTIFechaSalida.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTIFechaSalida.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTIFechaSalida.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFechaSalida.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTIFechaSalida.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTIFechaSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTIFechaSalida.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTIFechaSalida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFechaSalida.MonthCalendar.DisplayMonth = new System.DateTime(2026, 9, 1, 0, 0, 0, 0);
            this.DTIFechaSalida.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.DTIFechaSalida.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTIFechaSalida.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFechaSalida.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTIFechaSalida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFechaSalida.MonthCalendar.TodayButtonVisible = true;
            this.DTIFechaSalida.Name = "DTIFechaSalida";
            this.DTIFechaSalida.Size = new System.Drawing.Size(180, 22);
            this.DTIFechaSalida.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTIFechaSalida.TabIndex = 2;
            this.DTIFechaSalida.WatermarkText = "Fecha de Salida";
            // 
            // DTIFechaIngreso
            // 
            // 
            // 
            // 
            this.DTIFechaIngreso.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTIFechaIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.DTIFechaIngreso, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.DTIFechaIngreso, "Fecha de Ingreso de Empleado");
            this.DTIFechaIngreso.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTIFechaIngreso.ButtonDropDown.Visible = true;
            this.DTIFechaIngreso.IsPopupCalendarOpen = false;
            this.DTIFechaIngreso.Location = new System.Drawing.Point(6, 51);
            this.DTIFechaIngreso.MinDate = new System.DateTime(2026, 5, 8, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTIFechaIngreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFechaIngreso.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTIFechaIngreso.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTIFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTIFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTIFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTIFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTIFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTIFechaIngreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFechaIngreso.MonthCalendar.DisplayMonth = new System.DateTime(2026, 9, 1, 0, 0, 0, 0);
            this.DTIFechaIngreso.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.DTIFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTIFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTIFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTIFechaIngreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTIFechaIngreso.MonthCalendar.TodayButtonVisible = true;
            this.DTIFechaIngreso.Name = "DTIFechaIngreso";
            this.DTIFechaIngreso.Size = new System.Drawing.Size(180, 22);
            this.DTIFechaIngreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTIFechaIngreso.TabIndex = 3;
            this.DTIFechaIngreso.WatermarkText = "Fecha de Ingreso";
            // 
            // CMBTipoEmpleado
            // 
            this.BLTAyuda.SetBalloonCaption(this.CMBTipoEmpleado, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.CMBTipoEmpleado, "Tipo de Empleado");
            this.CMBTipoEmpleado.DisplayMember = "Text";
            this.CMBTipoEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBTipoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.CMBTipoEmpleado.FormattingEnabled = true;
            this.CMBTipoEmpleado.ItemHeight = 16;
            this.CMBTipoEmpleado.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.CMBTipoEmpleado.Location = new System.Drawing.Point(6, 23);
            this.CMBTipoEmpleado.Name = "CMBTipoEmpleado";
            this.CMBTipoEmpleado.Size = new System.Drawing.Size(180, 22);
            this.CMBTipoEmpleado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CMBTipoEmpleado.TabIndex = 1;
            this.CMBTipoEmpleado.WatermarkText = "Tipo de Empleado";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "COCINERO";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "MESERO";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "BARTENDER";
            // 
            // GPPersona
            // 
            this.GPPersona.BackColor = System.Drawing.Color.Gainsboro;
            this.BLTAyuda.SetBalloonCaption(this.GPPersona, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.GPPersona, "Datos de la Persona que Será un Empleado");
            this.GPPersona.CanvasColor = System.Drawing.Color.Black;
            this.GPPersona.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GPPersona.Controls.Add(this.TXTTipoDocumento);
            this.GPPersona.Controls.Add(this.TXTTipoPersona);
            this.GPPersona.Controls.Add(this.LBLAgregarPersona);
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
            this.GPPersona.Size = new System.Drawing.Size(385, 179);
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
            this.GPPersona.TabIndex = 0;
            // 
            // TXTTipoDocumento
            // 
            this.TXTTipoDocumento.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTTipoDocumento.Border.Class = "TextBoxBorder";
            this.TXTTipoDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTTipoDocumento.DisabledBackColor = System.Drawing.Color.White;
            this.TXTTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.TXTTipoDocumento.Location = new System.Drawing.Point(6, 51);
            this.TXTTipoDocumento.Multiline = true;
            this.TXTTipoDocumento.Name = "TXTTipoDocumento";
            this.TXTTipoDocumento.PreventEnterBeep = true;
            this.TXTTipoDocumento.ReadOnly = true;
            this.TXTTipoDocumento.Size = new System.Drawing.Size(180, 22);
            this.TXTTipoDocumento.TabIndex = 21;
            this.TXTTipoDocumento.WatermarkText = "Tipo de Documento";
            // 
            // TXTTipoPersona
            // 
            this.TXTTipoPersona.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTTipoPersona.Border.Class = "TextBoxBorder";
            this.TXTTipoPersona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTTipoPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTTipoPersona.DisabledBackColor = System.Drawing.Color.White;
            this.TXTTipoPersona.ForeColor = System.Drawing.Color.Black;
            this.TXTTipoPersona.Location = new System.Drawing.Point(6, 23);
            this.TXTTipoPersona.Multiline = true;
            this.TXTTipoPersona.Name = "TXTTipoPersona";
            this.TXTTipoPersona.PreventEnterBeep = true;
            this.TXTTipoPersona.ReadOnly = true;
            this.TXTTipoPersona.Size = new System.Drawing.Size(180, 22);
            this.TXTTipoPersona.TabIndex = 20;
            this.TXTTipoPersona.WatermarkText = "Tipo de Persona";
            // 
            // LBLAgregarPersona
            // 
            this.LBLAgregarPersona.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LBLAgregarPersona.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BLTAyuda.SetBalloonCaption(this.LBLAgregarPersona, "Ayuda");
            this.BLTAyuda.SetBalloonText(this.LBLAgregarPersona, "Enlace para Agregar una Persona a este Panel");
            this.LBLAgregarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAgregarPersona.ForeColor = System.Drawing.Color.OrangeRed;
            this.LBLAgregarPersona.Location = new System.Drawing.Point(267, 3);
            this.LBLAgregarPersona.Name = "LBLAgregarPersona";
            this.LBLAgregarPersona.Size = new System.Drawing.Size(105, 14);
            this.LBLAgregarPersona.TabIndex = 0;
            this.LBLAgregarPersona.Text = ">Agregar Persona...";
            this.LBLAgregarPersona.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.LBLAgregarPersona.Click += new System.EventHandler(this.LBLAgregarPersona_Click);
            this.LBLAgregarPersona.MouseLeave += new System.EventHandler(this.LBLAgregarPersona_MouseLeave);
            this.LBLAgregarPersona.MouseHover += new System.EventHandler(this.LBLAgregarPersona_MouseHover);
            // 
            // TXTCorreoElectronico
            // 
            this.TXTCorreoElectronico.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTCorreoElectronico.Border.Class = "TextBoxBorder";
            this.TXTCorreoElectronico.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTCorreoElectronico.DisabledBackColor = System.Drawing.Color.White;
            this.TXTCorreoElectronico.ForeColor = System.Drawing.Color.Black;
            this.TXTCorreoElectronico.Location = new System.Drawing.Point(192, 136);
            this.TXTCorreoElectronico.Multiline = true;
            this.TXTCorreoElectronico.Name = "TXTCorreoElectronico";
            this.TXTCorreoElectronico.PreventEnterBeep = true;
            this.TXTCorreoElectronico.ReadOnly = true;
            this.TXTCorreoElectronico.Size = new System.Drawing.Size(180, 23);
            this.TXTCorreoElectronico.TabIndex = 18;
            this.TXTCorreoElectronico.WatermarkText = "Correo Electrónico";
            // 
            // TXTTelefono
            // 
            this.TXTTelefono.BackColor = System.Drawing.Color.White;
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
            this.TXTTelefono.ReadOnly = true;
            this.TXTTelefono.Size = new System.Drawing.Size(180, 23);
            this.TXTTelefono.TabIndex = 17;
            this.TXTTelefono.WatermarkText = "Teléfono";
            // 
            // TXTNumeroDocumento
            // 
            this.TXTNumeroDocumento.BackColor = System.Drawing.Color.White;
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
            this.TXTNumeroDocumento.ReadOnly = true;
            this.TXTNumeroDocumento.Size = new System.Drawing.Size(180, 23);
            this.TXTNumeroDocumento.TabIndex = 12;
            this.TXTNumeroDocumento.WatermarkText = "Número de Documento";
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.BackColor = System.Drawing.Color.White;
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
            this.TXTDireccion.ReadOnly = true;
            this.TXTDireccion.Size = new System.Drawing.Size(366, 22);
            this.TXTDireccion.TabIndex = 16;
            this.TXTDireccion.WatermarkText = "Dirección";
            // 
            // TXTApellidoMaterno
            // 
            this.TXTApellidoMaterno.BackColor = System.Drawing.Color.White;
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
            this.TXTApellidoMaterno.ReadOnly = true;
            this.TXTApellidoMaterno.Size = new System.Drawing.Size(180, 23);
            this.TXTApellidoMaterno.TabIndex = 15;
            this.TXTApellidoMaterno.WatermarkText = "Apellido Materno";
            // 
            // TXTApellidoPaterno
            // 
            this.TXTApellidoPaterno.BackColor = System.Drawing.Color.White;
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
            this.TXTApellidoPaterno.ReadOnly = true;
            this.TXTApellidoPaterno.Size = new System.Drawing.Size(180, 22);
            this.TXTApellidoPaterno.TabIndex = 14;
            this.TXTApellidoPaterno.WatermarkText = "Apellido Paterno";
            // 
            // TXTNombres
            // 
            this.TXTNombres.BackColor = System.Drawing.Color.White;
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
            this.TXTNombres.ReadOnly = true;
            this.TXTNombres.Size = new System.Drawing.Size(180, 22);
            this.TXTNombres.TabIndex = 13;
            this.TXTNombres.WatermarkText = "Nombres";
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::RestoBar2026.Properties.Resources.icCancelarRedondo;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(267, 288);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(125, 44);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 4;
            this.BTNSalir.Text = "&Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::RestoBar2026.Properties.Resources.icLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(138, 288);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(123, 44);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 3;
            this.BTNLimpiar.Text = "&Limpiar";
            this.BTNLimpiar.Click += new System.EventHandler(this.BTN_Limpiar_Click);
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGrabar.Image = global::RestoBar2026.Properties.Resources.icGuardar;
            this.BTNGrabar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGrabar.Location = new System.Drawing.Point(7, 288);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(125, 44);
            this.BTNGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGrabar.TabIndex = 2;
            this.BTNGrabar.Text = "&Grabar";
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // FRMEmpleadoRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 365);
            this.Controls.Add(this.GPPanelProducto);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMEmpleadoRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMEmpleadoRegistrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMEmpleadoRegistrar_FormClosing);
            this.Load += new System.EventHandler(this.FRMEmpleadoRegistrar_Load);
            this.GPPanelProducto.ResumeLayout(false);
            this.GPBebida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DINSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFechaSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIFechaIngreso)).EndInit();
            this.GPPersona.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GPPanelProducto;
        private DevComponents.DotNetBar.Controls.GroupPanel GPBebida;
        private DevComponents.DotNetBar.Controls.GroupPanel GPPersona;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
        private DevComponents.DotNetBar.ButtonX BTNGrabar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApellidoPaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombres;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTDireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTApellidoMaterno;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNumeroDocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTCorreoElectronico;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTTelefono;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTIFechaIngreso;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMBTipoEmpleado;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.LabelX LBLEstado;
        private DevComponents.Editors.DoubleInput DINSalario;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTIFechaSalida;
        private DevComponents.DotNetBar.LabelX LBLAgregarPersona;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTTipoDocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTTipoPersona;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.BalloonTip BLTAyuda;
    }
}