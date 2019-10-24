namespace MicroSisPlani.Personal
{
    partial class Frm_Registro_Personal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registro_Personal));
			this.pnl_titulo = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_Salir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_Dni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_nombres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_direccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_correo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_IdPersona = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.txt_NroCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.dtp_fechaNaci = new MetroFramework.Controls.MetroDateTime();
			this.cbo_sexo = new System.Windows.Forms.ComboBox();
			this.cbo_rol = new System.Windows.Forms.ComboBox();
			this.cbo_Distrito = new System.Windows.Forms.ComboBox();
			this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
			this.Pic_persona = new System.Windows.Forms.PictureBox();
			this.btn_aceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
			this.btn_cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pnl_titulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Pic_persona)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_aceptar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_titulo
			// 
			this.pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnl_titulo.Controls.Add(this.label7);
			this.pnl_titulo.Controls.Add(this.btn_Salir);
			this.pnl_titulo.Controls.Add(this.label1);
			this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
			this.pnl_titulo.Name = "pnl_titulo";
			this.pnl_titulo.Size = new System.Drawing.Size(797, 50);
			this.pnl_titulo.TabIndex = 8;
			this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DimGray;
			this.label7.Location = new System.Drawing.Point(6, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(180, 20);
			this.label7.TabIndex = 25;
			this.label7.Text = "REGISTRO DE PERSONAL";
			// 
			// btn_Salir
			// 
			this.btn_Salir.FlatAppearance.BorderSize = 0;
			this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Salir.ForeColor = System.Drawing.Color.White;
			this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
			this.btn_Salir.Location = new System.Drawing.Point(750, 8);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(32, 32);
			this.btn_Salir.TabIndex = 1;
			this.toolTip1.SetToolTip(this.btn_Salir, "Salir / Cerrar Ventana");
			this.btn_Salir.UseVisualStyleBackColor = true;
			this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(0, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(797, 2);
			this.label1.TabIndex = 0;
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
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(88, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 24);
			this.label2.TabIndex = 26;
			this.toolTip1.SetToolTip(this.label2, "Nro de Dni");
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(88, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 24);
			this.label3.TabIndex = 28;
			this.toolTip1.SetToolTip(this.label3, "Nombre Completo");
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(88, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 24);
			this.label4.TabIndex = 30;
			this.toolTip1.SetToolTip(this.label4, "Direccion");
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(88, 252);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 24);
			this.label5.TabIndex = 32;
			this.toolTip1.SetToolTip(this.label5, "Correo electronico");
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(88, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 24);
			this.label6.TabIndex = 34;
			this.toolTip1.SetToolTip(this.label6, "Nro de Dni");
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(88, 299);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 24);
			this.label8.TabIndex = 36;
			this.toolTip1.SetToolTip(this.label8, "Nro de Celular");
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
			this.label9.Location = new System.Drawing.Point(375, 298);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(24, 24);
			this.label9.TabIndex = 37;
			this.toolTip1.SetToolTip(this.label9, "Fecha Nacimiento");
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.Location = new System.Drawing.Point(88, 343);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 24);
			this.label10.TabIndex = 45;
			this.toolTip1.SetToolTip(this.label10, "Sexo");
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
			this.label11.Location = new System.Drawing.Point(88, 380);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 24);
			this.label11.TabIndex = 46;
			this.toolTip1.SetToolTip(this.label11, "Rol del Personal");
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.Location = new System.Drawing.Point(88, 415);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 24);
			this.label12.TabIndex = 47;
			this.toolTip1.SetToolTip(this.label12, "Distrito");
			// 
			// txt_Dni
			// 
			this.txt_Dni.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Dni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_Dni.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_Dni.HintText = "Dni";
			this.txt_Dni.isPassword = false;
			this.txt_Dni.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_Dni.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_Dni.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_Dni.LineThickness = 2;
			this.txt_Dni.Location = new System.Drawing.Point(132, 97);
			this.txt_Dni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_Dni.Name = "txt_Dni";
			this.txt_Dni.Size = new System.Drawing.Size(168, 32);
			this.txt_Dni.TabIndex = 9;
			this.txt_Dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txt_nombres
			// 
			this.txt_nombres.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_nombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_nombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_nombres.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_nombres.HintText = "Nombre Completo";
			this.txt_nombres.isPassword = false;
			this.txt_nombres.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_nombres.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_nombres.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_nombres.LineThickness = 2;
			this.txt_nombres.Location = new System.Drawing.Point(132, 144);
			this.txt_nombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_nombres.Name = "txt_nombres";
			this.txt_nombres.Size = new System.Drawing.Size(438, 32);
			this.txt_nombres.TabIndex = 27;
			this.txt_nombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txt_direccion
			// 
			this.txt_direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_direccion.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_direccion.HintText = "Direccion";
			this.txt_direccion.isPassword = false;
			this.txt_direccion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_direccion.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_direccion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_direccion.LineThickness = 2;
			this.txt_direccion.Location = new System.Drawing.Point(132, 198);
			this.txt_direccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_direccion.Name = "txt_direccion";
			this.txt_direccion.Size = new System.Drawing.Size(438, 32);
			this.txt_direccion.TabIndex = 29;
			this.txt_direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txt_correo
			// 
			this.txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_correo.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_correo.HintText = "Correo";
			this.txt_correo.isPassword = false;
			this.txt_correo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_correo.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_correo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_correo.LineThickness = 2;
			this.txt_correo.Location = new System.Drawing.Point(132, 245);
			this.txt_correo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_correo.Name = "txt_correo";
			this.txt_correo.Size = new System.Drawing.Size(438, 32);
			this.txt_correo.TabIndex = 31;
			this.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.txt_IdPersona.Location = new System.Drawing.Point(132, 55);
			this.txt_IdPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_IdPersona.Name = "txt_IdPersona";
			this.txt_IdPersona.Size = new System.Drawing.Size(168, 32);
			this.txt_IdPersona.TabIndex = 33;
			this.txt_IdPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// txt_NroCelular
			// 
			this.txt_NroCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_NroCelular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_NroCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_NroCelular.HintForeColor = System.Drawing.Color.DarkGray;
			this.txt_NroCelular.HintText = "Nro de Celular";
			this.txt_NroCelular.isPassword = false;
			this.txt_NroCelular.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_NroCelular.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_NroCelular.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txt_NroCelular.LineThickness = 2;
			this.txt_NroCelular.Location = new System.Drawing.Point(132, 290);
			this.txt_NroCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_NroCelular.Name = "txt_NroCelular";
			this.txt_NroCelular.Size = new System.Drawing.Size(168, 32);
			this.txt_NroCelular.TabIndex = 35;
			this.txt_NroCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_NroCelular.OnValueChanged += new System.EventHandler(this.txt_NroCelular_OnValueChanged);
			// 
			// dtp_fechaNaci
			// 
			this.dtp_fechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_fechaNaci.Location = new System.Drawing.Point(414, 294);
			this.dtp_fechaNaci.MinimumSize = new System.Drawing.Size(0, 29);
			this.dtp_fechaNaci.Name = "dtp_fechaNaci";
			this.dtp_fechaNaci.Size = new System.Drawing.Size(156, 29);
			this.dtp_fechaNaci.TabIndex = 38;
			// 
			// cbo_sexo
			// 
			this.cbo_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_sexo.ForeColor = System.Drawing.Color.DimGray;
			this.cbo_sexo.FormattingEnabled = true;
			this.cbo_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
			this.cbo_sexo.Location = new System.Drawing.Point(132, 343);
			this.cbo_sexo.Name = "cbo_sexo";
			this.cbo_sexo.Size = new System.Drawing.Size(201, 28);
			this.cbo_sexo.TabIndex = 39;
			// 
			// cbo_rol
			// 
			this.cbo_rol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_rol.ForeColor = System.Drawing.Color.DimGray;
			this.cbo_rol.FormattingEnabled = true;
			this.cbo_rol.Location = new System.Drawing.Point(132, 377);
			this.cbo_rol.Name = "cbo_rol";
			this.cbo_rol.Size = new System.Drawing.Size(201, 28);
			this.cbo_rol.TabIndex = 40;
			// 
			// cbo_Distrito
			// 
			this.cbo_Distrito.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_Distrito.ForeColor = System.Drawing.Color.DimGray;
			this.cbo_Distrito.FormattingEnabled = true;
			this.cbo_Distrito.Location = new System.Drawing.Point(132, 411);
			this.cbo_Distrito.Name = "cbo_Distrito";
			this.cbo_Distrito.Size = new System.Drawing.Size(201, 28);
			this.cbo_Distrito.TabIndex = 41;
			// 
			// dtp_fecha
			// 
			this.dtp_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_fecha.Location = new System.Drawing.Point(576, 296);
			this.dtp_fecha.Name = "dtp_fecha";
			this.dtp_fecha.Size = new System.Drawing.Size(27, 22);
			this.dtp_fecha.TabIndex = 42;
			this.dtp_fecha.Visible = false;
			// 
			// Pic_persona
			// 
			this.Pic_persona.Image = ((System.Drawing.Image)(resources.GetObject("Pic_persona.Image")));
			this.Pic_persona.Location = new System.Drawing.Point(625, 79);
			this.Pic_persona.Name = "Pic_persona";
			this.Pic_persona.Size = new System.Drawing.Size(160, 151);
			this.Pic_persona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_persona.TabIndex = 43;
			this.Pic_persona.TabStop = false;
			this.Pic_persona.Click += new System.EventHandler(this.Pic_persona_Click);
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
			this.btn_aceptar.Location = new System.Drawing.Point(393, 479);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(239, 49);
			this.btn_aceptar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btn_aceptar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_aceptar.TabIndex = 44;
			this.btn_aceptar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_aceptar.TextStyle.ForeColor = System.Drawing.Color.White;
			this.btn_aceptar.TextStyle.Text = "Listo";
			this.btn_aceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_aceptar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
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
			this.btn_cancelar.Location = new System.Drawing.Point(137, 479);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(239, 49);
			this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.White;
			this.btn_cancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DimGray;
			this.btn_cancelar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.TabIndex = 48;
			this.btn_cancelar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancelar.TextStyle.ForeColor = System.Drawing.Color.DimGray;
			this.btn_cancelar.TextStyle.Text = "Cancelar";
			this.btn_cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Frm_Registro_Personal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(797, 553);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.Pic_persona);
			this.Controls.Add(this.dtp_fecha);
			this.Controls.Add(this.cbo_Distrito);
			this.Controls.Add(this.cbo_rol);
			this.Controls.Add(this.cbo_sexo);
			this.Controls.Add(this.dtp_fechaNaci);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txt_NroCelular);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_IdPersona);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_correo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_direccion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_nombres);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Dni);
			this.Controls.Add(this.pnl_titulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_Registro_Personal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro de Personal";
			this.Load += new System.EventHandler(this.Frm_Registro_Personal_Load);
			this.pnl_titulo.ResumeLayout(false);
			this.pnl_titulo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Pic_persona)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_aceptar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Dni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nombres;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_direccion;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_correo;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_IdPersona;
        private MetroFramework.Controls.MetroDateTime dtp_fechaNaci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NroCelular;
        private System.Windows.Forms.ComboBox cbo_sexo;
        internal System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cbo_Distrito;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.PictureBox Pic_persona;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_aceptar;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_cancelar;
    }
}