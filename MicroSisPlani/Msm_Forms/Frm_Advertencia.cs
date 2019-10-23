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
    public partial class Frm_Advertencia : Form
    {
        public Frm_Advertencia()
        {
            InitializeComponent();
        }

        private void Frm_Advertencia_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Advertencia_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button==MouseButtons.Left )
            {
                Utilitarios obj = new Utilitarios();
                obj.Mover_formulario(this);
            }
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Advertencia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                btn_acept_Click(sender, e);
            }
        }
    }
}
