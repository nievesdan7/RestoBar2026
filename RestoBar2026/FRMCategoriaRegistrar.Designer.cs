namespace RestoBar2026
{
    partial class FRMCategoriaRegistrar
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
            this.GPPanelCategoria = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TXTNombreCategoria = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SWBEstado = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.BTNLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.BTNSalir = new DevComponents.DotNetBar.ButtonX();
            this.BTNGrabar = new DevComponents.DotNetBar.ButtonX();
            this.GPPanelCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPPanelCategoria
            // 
            this.GPPanelCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GPPanelCategoria.CanvasColor = System.Drawing.SystemColors.Control;
            this.GPPanelCategoria.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GPPanelCategoria.Controls.Add(this.BTNLimpiar);
            this.GPPanelCategoria.Controls.Add(this.BTNSalir);
            this.GPPanelCategoria.Controls.Add(this.TXTNombreCategoria);
            this.GPPanelCategoria.Controls.Add(this.BTNGrabar);
            this.GPPanelCategoria.Controls.Add(this.SWBEstado);
            this.GPPanelCategoria.DisabledBackColor = System.Drawing.Color.Empty;
            this.GPPanelCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPPanelCategoria.Location = new System.Drawing.Point(0, 0);
            this.GPPanelCategoria.Name = "GPPanelCategoria";
            this.GPPanelCategoria.Size = new System.Drawing.Size(336, 106);
            // 
            // 
            // 
            this.GPPanelCategoria.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GPPanelCategoria.Style.BackColorGradientAngle = 90;
            this.GPPanelCategoria.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GPPanelCategoria.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelCategoria.Style.BorderBottomWidth = 1;
            this.GPPanelCategoria.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GPPanelCategoria.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelCategoria.Style.BorderLeftWidth = 1;
            this.GPPanelCategoria.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelCategoria.Style.BorderRightWidth = 1;
            this.GPPanelCategoria.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelCategoria.Style.BorderTopWidth = 1;
            this.GPPanelCategoria.Style.CornerDiameter = 4;
            this.GPPanelCategoria.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GPPanelCategoria.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GPPanelCategoria.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GPPanelCategoria.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GPPanelCategoria.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GPPanelCategoria.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GPPanelCategoria.TabIndex = 1;
            this.GPPanelCategoria.Text = "Categoria";
            // 
            // TXTNombreCategoria
            // 
            this.TXTNombreCategoria.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXTNombreCategoria.Border.Class = "TextBoxBorder";
            this.TXTNombreCategoria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXTNombreCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNombreCategoria.DisabledBackColor = System.Drawing.Color.White;
            this.TXTNombreCategoria.ForeColor = System.Drawing.Color.Black;
            this.TXTNombreCategoria.Location = new System.Drawing.Point(115, 3);
            this.TXTNombreCategoria.Name = "TXTNombreCategoria";
            this.TXTNombreCategoria.PreventEnterBeep = true;
            this.TXTNombreCategoria.Size = new System.Drawing.Size(206, 22);
            this.TXTNombreCategoria.TabIndex = 1;
            this.TXTNombreCategoria.WatermarkText = "Nombre de categoría";
            // 
            // SWBEstado
            // 
            // 
            // 
            // 
            this.SWBEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SWBEstado.Location = new System.Drawing.Point(9, 3);
            this.SWBEstado.Name = "SWBEstado";
            this.SWBEstado.OffBackColor = System.Drawing.Color.Red;
            this.SWBEstado.OffText = "Inhabilitado";
            this.SWBEstado.OffTextColor = System.Drawing.Color.White;
            this.SWBEstado.OnBackColor = System.Drawing.Color.LimeGreen;
            this.SWBEstado.OnText = "Habilitado";
            this.SWBEstado.OnTextColor = System.Drawing.Color.White;
            this.SWBEstado.Size = new System.Drawing.Size(100, 22);
            this.SWBEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SWBEstado.TabIndex = 0;
            this.SWBEstado.Value = true;
            this.SWBEstado.ValueObject = "Y";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNLimpiar.Image = global::RestoBar2026.Properties.Resources.icLimpiar;
            this.BTNLimpiar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNLimpiar.Location = new System.Drawing.Point(115, 31);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(100, 44);
            this.BTNLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNLimpiar.TabIndex = 20;
            this.BTNLimpiar.Text = "&Limpiar";
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNSalir.Image = global::RestoBar2026.Properties.Resources.icCancelarRedondo;
            this.BTNSalir.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNSalir.Location = new System.Drawing.Point(221, 31);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(100, 44);
            this.BTNSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNSalir.TabIndex = 19;
            this.BTNSalir.Text = "&Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNGrabar
            // 
            this.BTNGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNGrabar.Image = global::RestoBar2026.Properties.Resources.icGuardar;
            this.BTNGrabar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNGrabar.Location = new System.Drawing.Point(9, 31);
            this.BTNGrabar.Name = "BTNGrabar";
            this.BTNGrabar.Size = new System.Drawing.Size(100, 44);
            this.BTNGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNGrabar.TabIndex = 18;
            this.BTNGrabar.Text = "&Grabar";
            this.BTNGrabar.Click += new System.EventHandler(this.BTNGrabar_Click);
            // 
            // FRMCategoriaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 106);
            this.Controls.Add(this.GPPanelCategoria);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCategoriaRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCategoriaRegistrar";
            this.Load += new System.EventHandler(this.FRMCategoriaRegistrar_Load);
            this.GPPanelCategoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GPPanelCategoria;
        private DevComponents.DotNetBar.Controls.TextBoxX TXTNombreCategoria;
        private DevComponents.DotNetBar.Controls.SwitchButton SWBEstado;
        private DevComponents.DotNetBar.ButtonX BTNSalir;
        private DevComponents.DotNetBar.ButtonX BTNGrabar;
        private DevComponents.DotNetBar.ButtonX BTNLimpiar;
    }
}