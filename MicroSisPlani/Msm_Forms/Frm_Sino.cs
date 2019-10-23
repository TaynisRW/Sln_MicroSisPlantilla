using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroSisPlani.Msm_Forms
{
    public partial class Frm_Sino : Form
    {
        public Frm_Sino()
        {
            InitializeComponent();
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            this.Tag = "Si";
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();

        }

        private void lbl_Nomalgo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left )
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void Frm_Sino_Load(object sender, EventArgs e)
        {

        }
    }
}
