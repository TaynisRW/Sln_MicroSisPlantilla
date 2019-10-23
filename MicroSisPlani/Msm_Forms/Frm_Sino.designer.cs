namespace MicroSisPlani.Msm_Forms
{
    partial class Frm_Sino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sino));
            this.lbl_Nomalgo = new System.Windows.Forms.Label();
            this.Lbl_msm1 = new System.Windows.Forms.Label();
            this.BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_si = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_no = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_si)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nomalgo
            // 
            this.lbl_Nomalgo.AutoSize = true;
            this.lbl_Nomalgo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomalgo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Nomalgo.Location = new System.Drawing.Point(159, 33);
            this.lbl_Nomalgo.Name = "lbl_Nomalgo";
            this.lbl_Nomalgo.Size = new System.Drawing.Size(202, 36);
            this.lbl_Nomalgo.TabIndex = 23;
            this.lbl_Nomalgo.Text = "¿Seguro (a) ?";
            this.lbl_Nomalgo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Nomalgo_MouseMove);
            // 
            // Lbl_msm1
            // 
            this.Lbl_msm1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_msm1.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_msm1.Location = new System.Drawing.Point(130, 104);
            this.Lbl_msm1.Name = "Lbl_msm1";
            this.Lbl_msm1.Size = new System.Drawing.Size(379, 147);
            this.Lbl_msm1.TabIndex = 24;
            this.Lbl_msm1.Text = "¿Quieres Quitarlo del Carrito?";
            this.Lbl_msm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BunifuElipse1
            // 
            this.BunifuElipse1.ElipseRadius = 25;
            this.BunifuElipse1.TargetControl = this;
            // 
            // btn_si
            // 
            this.btn_si.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_si.BackgroundStyle.GradientAngle = 0F;
            this.btn_si.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_si.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_si.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_si.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.btn_si.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_si.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_si.EnableThemes = false;
            this.btn_si.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_si.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_si.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_si.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_si.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_si.Location = new System.Drawing.Point(91, 276);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(157, 42);
            this.btn_si.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.YellowGreen;
            this.btn_si.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.YellowGreen;
            this.btn_si.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_si.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_si.TabIndex = 26;
            this.btn_si.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_si.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.TextStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_si.TextStyle.Text = "Sí";
            this.btn_si.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_si.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_no
            // 
            this.btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_no.BackgroundStyle.GradientAngle = 0F;
            this.btn_no.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.BackgroundStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_no.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_no.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_no.EnableThemes = false;
            this.btn_no.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no.Location = new System.Drawing.Point(297, 276);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(157, 42);
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.TabIndex = 25;
            this.btn_no.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_no.TextStyle.Text = "No";
            this.btn_no.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_no.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Sino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.Lbl_msm1);
            this.Controls.Add(this.lbl_Nomalgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Sino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta";
            this.Load += new System.EventHandler(this.Frm_Sino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_si)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_Nomalgo;
        internal System.Windows.Forms.Label Lbl_msm1;
        internal Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_si;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_no;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}