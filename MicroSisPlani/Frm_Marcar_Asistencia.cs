//using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;



namespace MicroSisPlani
{
    public partial class Frm_Marcar_Asistencia : Form
    {
        public Frm_Marcar_Asistencia()
        {
            InitializeComponent();

        }


   

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Complementos move = new Complementos();
            if (e.Button ==MouseButtons.Left)
            {
                move.Mover_formulario(this);
            }
           

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      

       

      
    }
}
