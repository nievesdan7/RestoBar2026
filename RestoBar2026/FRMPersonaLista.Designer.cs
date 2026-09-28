namespace RestoBar2026
{
    partial class FRMPersonaLista
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DTGLista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.groupPanelBusqueda = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BTN_Buscar = new DevComponents.DotNetBar.ButtonX();
            this.TXTFiltrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IIN_Filas = new DevComponents.Editors.IntegerInput();
            this.EPN_Opciones = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Reporte = new DevComponents.DotNetBar.ButtonX();
            this.BTNEliminar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Modificar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Registrar = new DevComponents.DotNetBar.ButtonX();
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            this.groupPanelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).BeginInit();
            this.EPN_Opciones.SuspendLayout();
            this.CMSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGLista
            // 
            this.DTGLista.AllowUserToAddRows = false;
            this.DTGLista.AllowUserToDeleteRows = false;
            this.DTGLista.AllowUserToResizeColumns = false;
            this.DTGLista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.DTGLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGLista.BackgroundColor = System.Drawing.Color.White;
            this.DTGLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTGLista.ColumnHeadersHeight = 30;
            this.DTGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column11,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column12,
            this.Column13});
            this.DTGLista.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTGLista.DefaultCellStyle = dataGridViewCellStyle4;
            this.DTGLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGLista.EnableHeadersVisualStyles = false;
            this.DTGLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DTGLista.Location = new System.Drawing.Point(80, 99);
            this.DTGLista.Margin = new System.Windows.Forms.Padding(4);
            this.DTGLista.MultiSelect = false;
            this.DTGLista.Name = "DTGLista";
            this.DTGLista.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DTGLista.RowHeadersVisible = false;
            this.DTGLista.RowTemplate.Height = 30;
            this.DTGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLista.Size = new System.Drawing.Size(901, 386);
            this.DTGLista.TabIndex = 117;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.Checked = true;
            this.Column2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column2.CheckValue = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Estado";
            this.Column2.MinimumWidth = 70;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tipo Pers.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Tipo Doc.";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "N° Doc.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Nombres";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Ap. Pat.";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Ap. Mat.";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Dirección";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "Teléfono";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "Correo";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.groupPanelBusqueda);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(80, 0);
            this.expandablePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(901, 99);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 118;
            this.expandablePanel1.TitleHeight = 32;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Filtrar";
            // 
            // groupPanelBusqueda
            // 
            this.groupPanelBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupPanelBusqueda.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelBusqueda.Controls.Add(this.BTN_Buscar);
            this.groupPanelBusqueda.Controls.Add(this.TXTFiltrar);
            this.groupPanelBusqueda.Controls.Add(this.IIN_Filas);
            this.groupPanelBusqueda.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelBusqueda.Location = new System.Drawing.Point(8, 32);
            this.groupPanelBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanelBusqueda.Name = "groupPanelBusqueda";
            this.groupPanelBusqueda.Size = new System.Drawing.Size(386, 58);
            // 
            // 
            // 
            this.groupPanelBusqueda.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelBusqueda.Style.BackColorGradientAngle = 90;
            this.groupPanelBusqueda.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelBusqueda.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderBottomWidth = 1;
            this.groupPanelBusqueda.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelBusqueda.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderLeftWidth = 1;
            this.groupPanelBusqueda.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderRightWidth = 1;
            this.groupPanelBusqueda.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelBusqueda.Style.BorderTopWidth = 1;
            this.groupPanelBusqueda.Style.CornerDiameter = 4;
            this.groupPanelBusqueda.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelBusqueda.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelBusqueda.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelBusqueda.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelBusqueda.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelBusqueda.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelBusqueda.TabIndex = 14;
            this.groupPanelBusqueda.Text = "Búsqueda";
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Buscar.Image = global::RestoBar2026.Properties.Resources.icBuscar;
            this.BTN_Buscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Buscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Buscar.Location = new System.Drawing.Point(344, 4);
            this.BTN_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(22, 22);
            this.BTN_Buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Buscar.TabIndex = 14;
            // 
            // TXTFiltrar
            // 
            this.TXTFiltrar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTFiltrar.Border.Class = "TextBoxBorder";
            this.TXTFiltrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTFiltrar.DisabledBackColor = System.Drawing.Color.White;
            this.TXTFiltrar.ForeColor = System.Drawing.Color.Black;
            this.TXTFiltrar.Location = new System.Drawing.Point(124, 4);
            this.TXTFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.TXTFiltrar.Name = "TXTFiltrar";
            this.TXTFiltrar.PreventEnterBeep = true;
            this.TXTFiltrar.Size = new System.Drawing.Size(212, 22);
            this.TXTFiltrar.TabIndex = 13;
            this.TXTFiltrar.WatermarkText = "Datos a Buscar...";
            // 
            // IIN_Filas
            // 
            // 
            // 
            // 
            this.IIN_Filas.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.IIN_Filas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IIN_Filas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIN_Filas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIN_Filas.Increment = 10;
            this.IIN_Filas.Location = new System.Drawing.Point(9, 4);
            this.IIN_Filas.Margin = new System.Windows.Forms.Padding(4);
            this.IIN_Filas.MaxValue = 1000;
            this.IIN_Filas.MinValue = 0;
            this.IIN_Filas.Name = "IIN_Filas";
            this.IIN_Filas.ShowUpDown = true;
            this.IIN_Filas.Size = new System.Drawing.Size(107, 22);
            this.IIN_Filas.TabIndex = 10;
            this.IIN_Filas.Value = 50;
            // 
            // EPN_Opciones
            // 
            this.EPN_Opciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Opciones.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.EPN_Opciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Opciones.Controls.Add(this.BTN_Reporte);
            this.EPN_Opciones.Controls.Add(this.BTNEliminar);
            this.EPN_Opciones.Controls.Add(this.BTN_Modificar);
            this.EPN_Opciones.Controls.Add(this.BTN_Registrar);
            this.EPN_Opciones.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPN_Opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPN_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPN_Opciones.HideControlsWhenCollapsed = true;
            this.EPN_Opciones.Location = new System.Drawing.Point(0, 0);
            this.EPN_Opciones.Margin = new System.Windows.Forms.Padding(4);
            this.EPN_Opciones.Name = "EPN_Opciones";
            this.EPN_Opciones.Size = new System.Drawing.Size(80, 485);
            this.EPN_Opciones.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPN_Opciones.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPN_Opciones.Style.GradientAngle = 90;
            this.EPN_Opciones.TabIndex = 116;
            this.EPN_Opciones.TitleHeight = 32;
            this.EPN_Opciones.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPN_Opciones.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPN_Opciones.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPN_Opciones.TitleStyle.GradientAngle = 90;
            this.EPN_Opciones.TitleStyleMouseDown.BackColor1.Color = System.Drawing.Color.Transparent;
            this.EPN_Opciones.TitleText = "Opciones";
            // 
            // BTN_Reporte
            // 
            this.BTN_Reporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Reporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Reporte.Image = global::RestoBar2026.Properties.Resources.icCalendario;
            this.BTN_Reporte.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Reporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Reporte.Location = new System.Drawing.Point(0, 301);
            this.BTN_Reporte.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Reporte.Name = "BTN_Reporte";
            this.BTN_Reporte.Size = new System.Drawing.Size(80, 89);
            this.BTN_Reporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Reporte.TabIndex = 8;
            this.BTN_Reporte.Text = "&Reporte";
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNEliminar.Image = global::RestoBar2026.Properties.Resources.icBasurero;
            this.BTNEliminar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTNEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTNEliminar.Location = new System.Drawing.Point(0, 212);
            this.BTNEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(80, 89);
            this.BTNEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNEliminar.TabIndex = 7;
            this.BTNEliminar.Text = "&Eliminar";
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Modificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Modificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Modificar.Image = global::RestoBar2026.Properties.Resources.icEditar;
            this.BTN_Modificar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Modificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Modificar.Location = new System.Drawing.Point(0, 122);
            this.BTN_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(80, 90);
            this.BTN_Modificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Modificar.TabIndex = 5;
            this.BTN_Modificar.Text = "&Modificar ";
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Registrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Registrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Registrar.Image = global::RestoBar2026.Properties.Resources.icAgregar;
            this.BTN_Registrar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Registrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Registrar.Location = new System.Drawing.Point(0, 32);
            this.BTN_Registrar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(80, 90);
            this.BTN_Registrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Registrar.TabIndex = 4;
            this.BTN_Registrar.Text = "&Registrar ";
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.inhabilitarToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(128, 70);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            // 
            // inhabilitarToolStripMenuItem
            // 
            this.inhabilitarToolStripMenuItem.Name = "inhabilitarToolStripMenuItem";
            this.inhabilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inhabilitarToolStripMenuItem.Text = "&Inhabilitar";
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.habilitarToolStripMenuItem.Text = "&Habilitar";
            // 
            // FRMPersonaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 485);
            this.Controls.Add(this.DTGLista);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.EPN_Opciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMPersonaLista";
            this.Text = "FRMPersonaLista";
            this.Load += new System.EventHandler(this.FRMPersonaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLista)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.groupPanelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).EndInit();
            this.EPN_Opciones.ResumeLayout(false);
            this.CMSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DTGLista;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelBusqueda;
        private DevComponents.DotNetBar.ButtonX BTN_Buscar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTFiltrar;
        private DevComponents.Editors.IntegerInput IIN_Filas;
        private DevComponents.DotNetBar.ExpandablePanel EPN_Opciones;
        private DevComponents.DotNetBar.ButtonX BTN_Reporte;
        private DevComponents.DotNetBar.ButtonX BTNEliminar;
        private DevComponents.DotNetBar.ButtonX BTN_Modificar;
        private DevComponents.DotNetBar.ButtonX BTN_Registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
    }
}