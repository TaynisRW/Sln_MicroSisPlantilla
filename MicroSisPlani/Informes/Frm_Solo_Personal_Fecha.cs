using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;

namespace MicroSisPlani.Informes
{
    public partial class Frm_Solo_Personal_Fecha : Form
    {
        public Frm_Solo_Personal_Fecha()
        {
            InitializeComponent();
        }

        private void Frm_Solo_Personal_Fecha_Load(object sender, EventArgs e)
        {

          
            cbo_person.Focus();
        }

        //private void Cargar_Personal()
        //{
        //    RN_Personal obj = new RN_Personal();
        //    DataTable datos = new DataTable();

        //    datos = obj.RN_Leer_Todo_Personal();

        //    var cbo = cbo_person;
        //    cbo.DataSource = datos;
        //    cbo.ValueMember = "Id_Pernl";
        //    cbo.DisplayMember = "Nombre_Completo";

        //    cbo_person.SelectedIndex = -1;
            
        //}

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
            if (cbo_person.SelectedIndex == -1) { cbo_person.Focus(); return; }

            this.Tag = "A";
            this.Close();
        }
    }
}
