namespace MicroSisPlani
{
    partial class Frm_Explo_Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Explo_Asistencia));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.lbl_lupa = new System.Windows.Forms.Label();
            this.txt_Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_mini = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsv_asis = new System.Windows.Forms.ListView();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titulo.Controls.Add(this.dtp_fecha);
            this.pnl_titulo.Controls.Add(this.Lbl_total);
            this.pnl_titulo.Controls.Add(this.lbl_lupa);
            this.pnl_titulo.Controls.Add(this.txt_Buscar);
            this.pnl_titulo.Controls.Add(this.btn_mini);
            this.pnl_titulo.Controls.Add(this.label7);
            this.pnl_titulo.Controls.Add(this.btn_Salir);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1255, 50);
            this.pnl_titulo.TabIndex = 10;
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_total.Location = new System.Drawing.Point(860, 18);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(17, 20);
            this.Lbl_total.TabIndex = 31;
            this.Lbl_total.Text = "0";
            // 
            // lbl_lupa
            // 
            this.lbl_lupa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lupa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lupa.ForeColor = System.Drawing.Color.White;
            this.lbl_lupa.Image = ((System.Drawing.Image)(resources.GetObject("lbl_lupa.Image")));
            this.lbl_lupa.Location = new System.Drawing.Point(1126, 14);
            this.lbl_lupa.Name = "lbl_lupa";
            this.lbl_lupa.Size = new System.Drawing.Size(24, 24);
            this.lbl_lupa.TabIndex = 30;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Buscar.HintForeColor = System.Drawing.Color.DarkGray;
            this.txt_Buscar.HintText = "Buscar";
            this.txt_Buscar.isPassword = false;
            this.txt_Buscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Buscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Buscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Buscar.LineThickness = 2;
            this.txt_Buscar.Location = new System.Drawing.Point(906, 9);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(244, 32);
            this.txt_Buscar.TabIndex = 29;
            this.txt_Buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_mini
            // 
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.ForeColor = System.Drawing.Color.White;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(1168, 9);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(32, 32);
            this.btn_mini.TabIndex = 10;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "EXPLORADOR DE ASISTENCIAS";
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(1206, 9);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(32, 32);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1255, 2);
            this.label1.TabIndex = 0;
            // 
            // lsv_asis
            // 
            this.lsv_asis.Location = new System.Drawing.Point(3, 53);
            this.lsv_asis.Name = "lsv_asis";
            this.lsv_asis.Size = new System.Drawing.Size(1249, 461);
            this.lsv_asis.TabIndex = 11;
            this.lsv_asis.UseCompatibleStateImageBehavior = false;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(246, 18);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(98, 20);
            this.dtp_fecha.TabIndex = 32;
            this.dtp_fecha.Visible = false;
            // 
            // Frm_Explo_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 526);
            this.Controls.Add(this.lsv_asis);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Explo_Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador de Asistencia";
            this.Load += new System.EventHandler(this.Frm_Explo_Asistencia_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.Label lbl_lupa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Buscar;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsv_asis;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
    }
}