using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MicroSisPlani
{
    public partial class Frm_Explo_Asistencia : Form
    {
        public Frm_Explo_Asistencia()
        {
            InitializeComponent();
        }

        private void Frm_Explo_Asistencia_Load(object sender, EventArgs e)
        {

         

        }


    

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left )
            {
                Utilitarios u =new  Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     


     
    }
}
