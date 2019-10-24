
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using MicroSisPlani.Msm_Forms;



namespace MicroSisPlani.Personal
{
    public partial class Frm_Registro_Personal : Form
    {
        public Frm_Registro_Personal()
        {
            InitializeComponent();
        }

        //public bool editPerso = false;
      
        private void Frm_Registro_Personal_Load(object sender, EventArgs e)
        {
			Cargar_rol();
			Cargar_Distrito();
        }

		private void Cargar_rol()
		{
			RN_Rol obj = new RN_Rol();
			DataTable dt = new DataTable();

			try
			{
				dt = obj.RN_Buscar_Todos_Roles();
				if (dt.Rows.Count > 0)
				{
					var cbo = cbo_rol;
					cbo.DataSource = dt;
					cbo.DisplayMember = "NomRol";
					cbo.ValueMember = "Id_Rol";
				}
				cbo_rol.SelectedIndex = -1;
			}
			catch (Exception ex)
			{

			}
		}

		private void Cargar_Distrito()
		{
			RN_Distrito obj = new RN_Distrito();
			DataTable dt = new DataTable();

			try
			{
				dt = obj.RN_Buscar_Todos_Distrito();
				if (dt.Rows.Count > 0)
				{
					var cbo = cbo_Distrito;
					cbo.DataSource = dt;
					cbo.DisplayMember = "Distrito";
					cbo.ValueMember = "Id_Distrito";
				}
				cbo_Distrito.SelectedIndex = -1;
			}
			catch (Exception ex)
			{

			}
		}

		private bool ValidarCajasTexto()
		{
			Frm_Advertencia ver = new Frm_Advertencia();
			Frm_Filtro fil = new Frm_Filtro();

			if (txt_Dni.Text.Trim().Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "El número de Dni debe tener 8 Dígitos"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }

			if (txt_Dni.Text.Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "El número de Dni debe tener 8 Dígitos"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
			if (txt_nombres.Text.Length < 4) { fil.Show(); ver.Lbl_Msm1.Text = "Ingresa el nombre del Personal"; ver.ShowDialog(); fil.Hide(); txt_nombres.Focus(); return false; }
			if (txt_direccion.Text.Length < 4) { fil.Show(); ver.Lbl_Msm1.Text = "Ingresa la dirección del personal"; ver.ShowDialog(); fil.Hide(); txt_direccion.Focus(); return false; }
			if (txt_correo.Text.Length < 4) { fil.Show(); ver.Lbl_Msm1.Text = "Ingresa un correo válido"; ver.ShowDialog(); fil.Hide(); txt_correo.Focus(); return false; }
			if (txt_NroCelular.Text.Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "Ingresa un número de celular válido"; ver.ShowDialog(); fil.Hide(); txt_NroCelular.Focus(); return false; }
			if (txt_IdPersona.Text.Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "No se generó el ID personal correctamente"; ver.ShowDialog(); fil.Hide(); txt_IdPersona.Focus(); return false; }

			if (cbo_sexo.SelectedIndex == -1) { fil.Show(); ver.Lbl_Msm1.Text = "Seleccionar sexo del personal"; ver.ShowDialog(); fil.Hide(); cbo_sexo.Focus(); return false; }
			if (cbo_rol.SelectedIndex == -1) { fil.Show(); ver.Lbl_Msm1.Text = "Selecciona el rol del personal"; ver.ShowDialog(); fil.Hide(); cbo_rol.Focus(); return false; }
			if (cbo_Distrito.SelectedIndex == -1) { fil.Show(); ver.Lbl_Msm1.Text = "Selecciona el distrito del personal"; ver.ShowDialog(); fil.Hide(); cbo_Distrito.Focus(); return false; }

			return true;
		}

		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			Frm_Advertencia ok = new Frm_Advertencia();
			Frm_Filtro fil = new Frm_Filtro();
			RN_Personal objper = new RN_Personal();

			if (ValidarCajasTexto() == false) return;

			Guardar_Personal();
		}

		private void Guardar_Personal()
		{
			Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
			Frm_Filtro fil = new Frm_Filtro();
			RN_Personal obj= new RN_Personal();
			EN_Persona per = new EN_Persona();

			try
			{
				per.Idpersonal = txt_IdPersona.Text;
				per.Dni = txt_Dni.Text;
				per.Nombres = txt_nombres.Text;
				per.anoNacimiento = dtp_fecha.Value;
				per.Sexo = cbo_sexo.Text;
				per.Direccion = txt_direccion.Text;
				per.Correo = txt_correo.Text;
				per.Celular = Convert.ToInt32(txt_NroCelular.Text);
				per.IdRol = Convert.ToString(cbo_rol.SelectedValue);
				per.xImagen = xFotoruta;
				per.IdDistrito = Convert.ToString(cbo_Distrito.SelectedValue);

				obj.RN_Registrar_Personal(per);

				if (BD_Personal.saved == true)
				{
					fil.Show();
					ok.Lbl_msm1.Text = "Los datos del personal se han guardado correctamente";
					ok.ShowDialog();
					fil.Hide();

					this.Tag = "A";
					this.Close();
				}
			}
			catch (Exception ex)
			{

			}
		}

		string xFotoruta;

		private void Pic_persona_Click(object sender, EventArgs e)
		{
			var filepath = string.Empty;
			try
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					xFotoruta = openFileDialog1.FileName;
					Pic_persona.Load(xFotoruta);
				}
			}
			catch (Exception ex)
			{
				xFotoruta = Application.StartupPath + @"\user.png";
				Pic_persona.Load( Application.StartupPath + @"\user.png");
			}
		}

		private void btn_Salir_Click(object sender, EventArgs e)
		{
			this.Tag = "";
			this.Close();
		}

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Tag = "";
			this.Close();
		}

		private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Utilitarios u = new Utilitarios();
				u.Mover_formulario(this);
			}
		}

		bool xedit = false;

		private void txt_NroCelular_OnValueChanged(object sender, EventArgs e)
		{
			string xcar1, xcar2;

			if (xedit == false)
			{
				if (txt_Dni.Text.Length == 0) return;
				if (txt_nombres.Text.Length == 0) return;

				xcar1 = Convert.ToString(txt_Dni.Text).Substring(3, 5);
				xcar2 = Convert.ToString(txt_nombres.Text).Substring(1, 4);
				txt_IdPersona.Text = xcar1 + "-" + xcar2;
			}
		}
	}
}
