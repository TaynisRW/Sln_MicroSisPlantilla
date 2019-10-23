using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroSisPlani.Informes
{
    public partial class Frm_Solo_Fecha : Form
    {
        public Frm_Solo_Fecha()
        {
            InitializeComponent();
        }

        private void lbl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left )
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Tag = "A";
            this.Close();
        }
    }
}
