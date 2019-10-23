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
    public partial class Frm_Print_Asistencia : Form
    {
        public Frm_Print_Asistencia()
        {
            InitializeComponent();
        }


        public DateTime FechaConsult;

        public string CualImprimir ;


        private void Frm_Print_Asistencia_Load(object sender, EventArgs e)
        {
          

           

        }




        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left )
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

     
    }
}
