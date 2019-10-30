namespace MicroSisPlani.Informes
{
	partial class Frm_Print_Asisdeldia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Print_Asisdeldia));
			this.pnl_titulo = new System.Windows.Forms.Panel();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.btn_exportar = new System.Windows.Forms.Button();
			this.btn_Imprimir = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.vsr_infodia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.pnl_titulo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_titulo
			// 
			this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pnl_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnl_titulo.Controls.Add(this.btn_refresh);
			this.pnl_titulo.Controls.Add(this.btn_exportar);
			this.pnl_titulo.Controls.Add(this.btn_Imprimir);
			this.pnl_titulo.Controls.Add(this.btn_Cerrar);
			this.pnl_titulo.Controls.Add(this.lbl_Titulo);
			this.pnl_titulo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
			this.pnl_titulo.Name = "pnl_titulo";
			this.pnl_titulo.Size = new System.Drawing.Size(1018, 53);
			this.pnl_titulo.TabIndex = 430;
			this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_titulo_MouseMove);
			// 
			// btn_refresh
			// 
			this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_refresh.FlatAppearance.BorderSize = 0;
			this.btn_refresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
			this.btn_refresh.Location = new System.Drawing.Point(848, 13);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(24, 24);
			this.btn_refresh.TabIndex = 429;
			this.btn_refresh.UseVisualStyleBackColor = true;
			this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
			// 
			// btn_exportar
			// 
			this.btn_exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_exportar.FlatAppearance.BorderSize = 0;
			this.btn_exportar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_exportar.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar.Image")));
			this.btn_exportar.Location = new System.Drawing.Point(881, 12);
			this.btn_exportar.Name = "btn_exportar";
			this.btn_exportar.Size = new System.Drawing.Size(24, 24);
			this.btn_exportar.TabIndex = 428;
			this.btn_exportar.UseVisualStyleBackColor = true;
			this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
			// 
			// btn_Imprimir
			// 
			this.btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Imprimir.FlatAppearance.BorderSize = 0;
			this.btn_Imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_Imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Imprimir.Image")));
			this.btn_Imprimir.Location = new System.Drawing.Point(915, 13);
			this.btn_Imprimir.Name = "btn_Imprimir";
			this.btn_Imprimir.Size = new System.Drawing.Size(24, 24);
			this.btn_Imprimir.TabIndex = 427;
			this.btn_Imprimir.UseVisualStyleBackColor = true;
			this.btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cerrar.FlatAppearance.BorderSize = 0;
			this.btn_Cerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
			this.btn_Cerrar.Location = new System.Drawing.Point(988, 12);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(18, 18);
			this.btn_Cerrar.TabIndex = 426;
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
			// 
			// lbl_Titulo
			// 
			this.lbl_Titulo.AutoSize = true;
			this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lbl_Titulo.Location = new System.Drawing.Point(12, 14);
			this.lbl_Titulo.Name = "lbl_Titulo";
			this.lbl_Titulo.Size = new System.Drawing.Size(166, 20);
			this.lbl_Titulo.TabIndex = 40;
			this.lbl_Titulo.Text = "Impresion de Recibos";
			this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// vsr_infodia
			// 
			this.vsr_infodia.ActiveViewIndex = -1;
			this.vsr_infodia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vsr_infodia.Cursor = System.Windows.Forms.Cursors.Default;
			this.vsr_infodia.DisplayToolbar = false;
			this.vsr_infodia.Dock = System.Windows.Forms.DockStyle.Top;
			this.vsr_infodia.Location = new System.Drawing.Point(0, 53);
			this.vsr_infodia.Name = "vsr_infodia";
			this.vsr_infodia.Size = new System.Drawing.Size(1018, 588);
			this.vsr_infodia.TabIndex = 431;
			this.vsr_infodia.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
			// 
			// Frm_Print_Asisdeldia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1018, 653);
			this.Controls.Add(this.vsr_infodia);
			this.Controls.Add(this.pnl_titulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Frm_Print_Asisdeldia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Asistencias del Día";
			this.Load += new System.EventHandler(this.Frm_Print_Asisdeldia_Load);
			this.pnl_titulo.ResumeLayout(false);
			this.pnl_titulo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Panel pnl_titulo;
		internal System.Windows.Forms.Button btn_refresh;
		internal System.Windows.Forms.Button btn_exportar;
		internal System.Windows.Forms.Button btn_Imprimir;
		internal System.Windows.Forms.Button btn_Cerrar;
		internal System.Windows.Forms.Label lbl_Titulo;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer vsr_infodia;
	}
}