namespace MicroSisPlani
{
    partial class Frm_Reg_Justificacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reg_Justificacion));
			this.pnl_titulo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_IdPersona = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_idjusti = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.cbo_motivJusti = new System.Windows.Forms.ComboBox();
			this.txt_DetalleJusti = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
			this.btn_cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
			this.btn_aceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
			this.Label4 = new System.Windows.Forms.Label();
			this.Dtp_FechaJusti = new System.Windows.Forms.DateTimePicker();
			this.txt_nompersona = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.pnl_titulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_DetalleJusti)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_aceptar)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_titulo
			// 
			this.pnl_titulo.BackColor = System.Drawing.Color.White;
			this.pnl_titulo.Controls.Add(this.label1);
			this.pnl_titulo.Controls.Add(this.lbl_titulo);
			this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
			this.pnl_titulo.Name = "pnl_titulo";
			this.pnl_titulo.Size = new System.Drawing.Size(550, 50);
			this.pnl_titulo.TabIndex = 9;
			this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(0, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(550, 2);
			this.label1.TabIndex = 0;
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.AutoSize = true;
			this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
			this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titulo.ForeColor = System.Drawing.Color.DimGray;
			this.lbl_titulo.Location = new System.Drawing.Point(155, 12);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(245, 23);
			this.lbl_titulo.TabIndex = 25;
			this.lbl_titulo.Text = "SOLICITAR JUSTIFICACION";
			this.lbl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_titulo_MouseMove);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(31, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 24);
			this.label3.TabIndex = 90;
			this.toolTip1.SetToolTip(this.label3, "Nombre Completo");
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
			this.label11.Location = new System.Drawing.Point(31, 253);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 24);
			this.label11.TabIndex = 49;
			this.toolTip1.SetToolTip(this.label11, "Detalle de la Justificacion");
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.Location = new System.Drawing.Point(31, 209);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 24);
			this.label10.TabIndex = 47;
			this.toolTip1.SetToolTip(this.label10, "Motivo de Justificacion");
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(31, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 24);
			this.label2.TabIndex = 38;
			this.toolTip1.SetToolTip(this.label2, "Id Justificacion");
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(31, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 24);
			this.label6.TabIndex = 36;
			this.toolTip1.SetToolTip(this.label6, "Id Personal");
			// 
			// txt_IdPersona
			// 
			this.txt_IdPersona.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_IdPersona.Enabled = false;
			this.txt_IdPersona.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_IdPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_IdPersona.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_IdPersona.HintText = "Id Personal";
			this.txt_IdPersona.isPassword = false;
			this.txt_IdPersona.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_IdPersona.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_IdPersona.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_IdPersona.LineThickness = 2;
			this.txt_IdPersona.Location = new System.Drawing.Point(75, 68);
			this.txt_IdPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_IdPersona.Name = "txt_IdPersona";
			this.txt_IdPersona.Size = new System.Drawing.Size(168, 32);
			this.txt_IdPersona.TabIndex = 35;
			this.txt_IdPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txt_idjusti
			// 
			this.txt_idjusti.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_idjusti.Enabled = false;
			this.txt_idjusti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_idjusti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_idjusti.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_idjusti.HintText = "Id Justificacion";
			this.txt_idjusti.isPassword = false;
			this.txt_idjusti.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_idjusti.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_idjusti.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_idjusti.LineThickness = 2;
			this.txt_idjusti.Location = new System.Drawing.Point(72, 159);
			this.txt_idjusti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_idjusti.Name = "txt_idjusti";
			this.txt_idjusti.Size = new System.Drawing.Size(168, 32);
			this.txt_idjusti.TabIndex = 37;
			this.txt_idjusti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// cbo_motivJusti
			// 
			this.cbo_motivJusti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_motivJusti.ForeColor = System.Drawing.Color.DimGray;
			this.cbo_motivJusti.FormattingEnabled = true;
			this.cbo_motivJusti.Items.AddRange(new object[] {
            "Por Falta",
            "Por Tardanza"});
			this.cbo_motivJusti.Location = new System.Drawing.Point(72, 209);
			this.cbo_motivJusti.Name = "cbo_motivJusti";
			this.cbo_motivJusti.Size = new System.Drawing.Size(201, 28);
			this.cbo_motivJusti.TabIndex = 46;
			// 
			// txt_DetalleJusti
			// 
			this.txt_DetalleJusti.AutoSize = false;
			this.txt_DetalleJusti.CaptionStyle.CaptionSize = 0;
			this.txt_DetalleJusti.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
			this.txt_DetalleJusti.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
			this.txt_DetalleJusti.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
			this.txt_DetalleJusti.CaptionStyle.TextStyle.Text = "elEntryBox1";
			this.txt_DetalleJusti.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
			this.txt_DetalleJusti.EditBoxStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_DetalleJusti.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_DetalleJusti.Location = new System.Drawing.Point(72, 253);
			this.txt_DetalleJusti.Name = "txt_DetalleJusti";
			this.txt_DetalleJusti.Size = new System.Drawing.Size(462, 89);
			this.txt_DetalleJusti.TabIndex = 48;
			this.txt_DetalleJusti.ValidationStyle.PasswordChar = '\0';
			this.txt_DetalleJusti.Value = "";
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
			this.btn_cancelar.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
			this.btn_cancelar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_cancelar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_cancelar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_cancelar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_cancelar.BorderStyle.SolidColor = System.Drawing.Color.DimGray;
			this.btn_cancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
			this.btn_cancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
			this.btn_cancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancelar.Location = new System.Drawing.Point(83, 386);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(145, 37);
			this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DimGray;
			this.btn_cancelar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.TabIndex = 51;
			this.btn_cancelar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.TextStyle.ForeColor = System.Drawing.Color.DimGray;
			this.btn_cancelar.TextStyle.Text = "Cancelar";
			this.btn_cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
			this.btn_aceptar.BackgroundStyle.SolidColor = System.Drawing.Color.DimGray;
			this.btn_aceptar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_aceptar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_aceptar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_aceptar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
			this.btn_aceptar.BorderStyle.SolidColor = System.Drawing.Color.DimGray;
			this.btn_aceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
			this.btn_aceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
			this.btn_aceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_aceptar.Location = new System.Drawing.Point(277, 386);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(170, 37);
			this.btn_aceptar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_aceptar.TabIndex = 50;
			this.btn_aceptar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_aceptar.TextStyle.ForeColor = System.Drawing.Color.White;
			this.btn_aceptar.TextStyle.Text = "Listo";
			this.btn_aceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_aceptar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label4.Location = new System.Drawing.Point(386, 190);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(127, 18);
			this.Label4.TabIndex = 88;
			this.Label4.Text = "| Para cuando es?";
			// 
			// Dtp_FechaJusti
			// 
			this.Dtp_FechaJusti.CalendarForeColor = System.Drawing.Color.DeepSkyBlue;
			this.Dtp_FechaJusti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Dtp_FechaJusti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Dtp_FechaJusti.Location = new System.Drawing.Point(389, 211);
			this.Dtp_FechaJusti.Name = "Dtp_FechaJusti";
			this.Dtp_FechaJusti.Size = new System.Drawing.Size(132, 26);
			this.Dtp_FechaJusti.TabIndex = 87;
			// 
			// txt_nompersona
			// 
			this.txt_nompersona.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_nompersona.Enabled = false;
			this.txt_nompersona.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nompersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_nompersona.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_nompersona.HintText = "Nombre";
			this.txt_nompersona.isPassword = false;
			this.txt_nompersona.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_nompersona.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_nompersona.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_nompersona.LineThickness = 2;
			this.txt_nompersona.Location = new System.Drawing.Point(75, 117);
			this.txt_nompersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_nompersona.Name = "txt_nompersona";
			this.txt_nompersona.Size = new System.Drawing.Size(462, 32);
			this.txt_nompersona.TabIndex = 89;
			this.txt_nompersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// Frm_Reg_Justificacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(550, 455);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_nompersona);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Dtp_FechaJusti);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txt_DetalleJusti);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cbo_motivJusti);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_idjusti);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_IdPersona);
			this.Controls.Add(this.pnl_titulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Frm_Reg_Justificacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registrar Justificacion";
			this.Load += new System.EventHandler(this.Frm_Reg_Justificacion_Load);
			this.pnl_titulo.ResumeLayout(false);
			this.pnl_titulo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_DetalleJusti)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_aceptar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_motivJusti;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_DetalleJusti;
        private System.Windows.Forms.Label label11;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_cancelar;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_aceptar;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker Dtp_FechaJusti;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_IdPersona;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_nompersona;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_idjusti;
    }
}