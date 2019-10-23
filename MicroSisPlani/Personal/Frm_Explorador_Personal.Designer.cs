namespace MicroSisPlani.Personal
{
    partial class Frm_Explorador_Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Explorador_Personal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.lbl_lupa = new System.Windows.Forms.Label();
            this.txt_Buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_mini = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsv_person = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_nuevoPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_editarPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_eliminarPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_mostrarTodoElPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_registrarHuellaDigital = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl_titulo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.pnl_titulo.Size = new System.Drawing.Size(1250, 50);
            this.pnl_titulo.TabIndex = 9;
            
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
            this.toolTip1.SetToolTip(this.Lbl_total, "Total de Personal Encontrado");
           
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
           
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "EXPLORADOR DE PERSONAL";
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
          
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1250, 2);
            this.label1.TabIndex = 0;
            // 
            // lsv_person
            // 
            this.lsv_person.ContextMenuStrip = this.contextMenuStrip1;
            this.lsv_person.Location = new System.Drawing.Point(3, 56);
            this.lsv_person.Name = "lsv_person";
            this.lsv_person.Size = new System.Drawing.Size(1235, 453);
            this.lsv_person.TabIndex = 10;
            this.lsv_person.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_nuevoPersonal,
            this.toolStripSeparator1,
            this.bt_editarPersonal,
            this.toolStripSeparator4,
            this.bt_registrarHuellaDigital,
            this.toolStripSeparator2,
            this.bt_eliminarPersonal,
            this.toolStripSeparator3,
            this.bt_mostrarTodoElPersonal});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 158);
            // 
            // bt_nuevoPersonal
            // 
            this.bt_nuevoPersonal.Image = ((System.Drawing.Image)(resources.GetObject("bt_nuevoPersonal.Image")));
            this.bt_nuevoPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bt_nuevoPersonal.Name = "bt_nuevoPersonal";
            this.bt_nuevoPersonal.Size = new System.Drawing.Size(210, 26);
            this.bt_nuevoPersonal.Text = "Nuevo Personal";
           
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // bt_editarPersonal
            // 
            this.bt_editarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("bt_editarPersonal.Image")));
            this.bt_editarPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bt_editarPersonal.Name = "bt_editarPersonal";
            this.bt_editarPersonal.Size = new System.Drawing.Size(210, 26);
            this.bt_editarPersonal.Text = "Editar Personal";
          
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // bt_eliminarPersonal
            // 
            this.bt_eliminarPersonal.Image = ((System.Drawing.Image)(resources.GetObject("bt_eliminarPersonal.Image")));
            this.bt_eliminarPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bt_eliminarPersonal.Name = "bt_eliminarPersonal";
            this.bt_eliminarPersonal.Size = new System.Drawing.Size(210, 26);
            this.bt_eliminarPersonal.Text = "Eliminar Personal";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // bt_mostrarTodoElPersonal
            // 
            this.bt_mostrarTodoElPersonal.Name = "bt_mostrarTodoElPersonal";
            this.bt_mostrarTodoElPersonal.Size = new System.Drawing.Size(210, 26);
            this.bt_mostrarTodoElPersonal.Text = "Mostrar Todo el Personal";
          
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.consultasToolStripMenuItem.Text = "***************** Consultas ******";
            // 
            // bt_registrarHuellaDigital
            // 
            this.bt_registrarHuellaDigital.Image = ((System.Drawing.Image)(resources.GetObject("bt_registrarHuellaDigital.Image")));
            this.bt_registrarHuellaDigital.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bt_registrarHuellaDigital.Name = "bt_registrarHuellaDigital";
            this.bt_registrarHuellaDigital.Size = new System.Drawing.Size(210, 26);
            this.bt_registrarHuellaDigital.Text = "Registrar Huella Digital";
           
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(207, 6);
            // 
            // Frm_Explorador_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 521);
            this.Controls.Add(this.lsv_person);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Explorador_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador de Personal";
            this.Load += new System.EventHandler(this.Frm_Explorador_Personal_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lupa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Buscar;
        private System.Windows.Forms.ListView lsv_person;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bt_nuevoPersonal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bt_editarPersonal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem bt_eliminarPersonal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem bt_mostrarTodoElPersonal;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bt_registrarHuellaDigital;
    }
}