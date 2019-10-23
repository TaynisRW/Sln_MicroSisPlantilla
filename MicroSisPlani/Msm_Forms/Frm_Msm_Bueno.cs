using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MicroSisPlani.Msm_Forms
{
    public partial class Frm_Msm_Bueno : Form
    {
        public Frm_Msm_Bueno()
        {
            InitializeComponent();
        }

        private void Frm_Msm_Bueno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                btn_acept_Click(sender, e);
            }
        }

        private void btn_acept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tocar_timbre ()
        {
            string ruta;
            ruta = Application.ExecutablePath;
            System.Media.SoundPlayer son;
            son = new System.Media.SoundPlayer(ruta + @"\Gotaagua.wav");
            son.Play();
                       
        }

        private void Frm_Msm_Bueno_Load(object sender, EventArgs e)
        {
            tocar_timbre();
        }
    }
}
