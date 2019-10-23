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


namespace MicroSisPlani
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

		private bool ValidarTextbox()
		{
			if (txt_usu.Text.Trim().Length == 0) { MessageBox.Show("Ingresa tu usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txt_usu.Focus(); return false; }
			if (txt_pass.Text.Trim().Length == 0) { MessageBox.Show("Ingresa tu contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txt_pass.Focus(); return false; }

			return true;
		}

		private void AccederAlSistema()
		{
			RN_Usuario obj = new RN_Usuario();
			DataTable dt = new DataTable();

			int veces = 0;

			if (ValidarTextbox() == false) return;

			string usu, pass;
			usu = txt_usu.Text.Trim();
			pass = txt_pass.Text.Trim();

			if (obj.RN_Verificar_Acceso(usu, pass) == true)
			{
				//los datos son correctos:
				MessageBox.Show("Bienvenido al sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Frm_Principal prin = new Frm_Principal();
				this.Hide();
				prin.Show();
			}
			else
			{
				//los datos no son correctos:
				MessageBox.Show("Usuario o Contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_pass.Text = "";
				txt_usu.Text = "";
				txt_usu.Focus();
				veces += 1;

				if (veces == 3)
				{
					MessageBox.Show("El número máximo de intentos fue superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Application.Exit();
				}
			}
		}

		private void Btn_Salir_Click(object sender, EventArgs e)
		{
			Application.Exit();	
		}

		private void Pnl_titulo_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Utilitarios u = new Utilitarios();
				u.Mover_formulario(this);
			}
		}

		private void Btn_Aceptar_Click(object sender, EventArgs e)
		{
			AccederAlSistema();
		}
	}
}
