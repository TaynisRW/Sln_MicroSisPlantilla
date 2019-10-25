using MicroSisPlani.Personal;
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
using System.IO;

namespace MicroSisPlani
{
	public partial class Frm_Principal : Form
	{
		public Frm_Principal()
		{
			InitializeComponent();
		}

		private void Frm_Principal_Load(object sender, EventArgs e)
		{
			ConfiguraListView();

		}

		public void Cargar_Datos_usuario()
		{
			try
			{
				Frm_Filtro xfil = new Frm_Filtro();

				xfil.Show();
				MessageBox.Show("Bienvenido al sistema: " + Cls_Libreria.Apellidos, "Bienvenido al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
				xfil.Hide();

				Lbl_NomUsu.Text = Cls_Libreria.Apellidos;
				lbl_rolNom.Text = Cls_Libreria.Rol;

				if (Cls_Libreria.Foto.Trim().Length == 0 | Cls_Libreria.Foto == null) return;

				if (File.Exists(Cls_Libreria.Foto) == true)
				{
					pic_user.Load(Cls_Libreria.Foto);
				}
				else
				{
					pic_user.Image = Properties.Resources.user;
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Utilitarios u = new Utilitarios();
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

		private void button1_Click(object sender, EventArgs e)
		{
			Frm_Explorador_Personal pers = new Frm_Explorador_Personal();
			pers.MdiParent = this;
			pers.Show();

		}

		private void bt_personal_Click(object sender, EventArgs e)
		{

			elTabPage2.Visible = true;
			elTab1.SelectedTabPageIndex = 1;
			Cargar_todo_Perosnal();


		}

		private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
		{
			Frm_Filtro fil = new Frm_Filtro();
			Frm_Sino sino = new Frm_Sino();

			fil.Show();
			sino.Lbl_msm1.Text = "¿Estás seguro que deseas salir y abandonar el sistema?";
			sino.ShowDialog();
			fil.Hide();

			if (Convert.ToString(sino.Tag) == "Si")
			{
				Application.ExitThread();
			}
			else
			{
				e.Cancel = true;
			}


		}

		private void btn_nuevoAsis_Click(object sender, EventArgs e)
		{

		}

		private void bt_Explo_Asis_Click(object sender, EventArgs e)
		{



		}

		private void Btn_Cerrar_TabPers_Click(object sender, EventArgs e)
		{
			elTabPage2.Visible = false;
			elTab1.SelectedTabPageIndex = 0;
		}

		private void btn_cerrarEx_Asis_Click(object sender, EventArgs e)
		{
			elTabPage3.Visible = false;
			elTab1.SelectedTabPageIndex = 0;
		}

		private void bt_copiarNroDNI_Click(object sender, EventArgs e)
		{
			Frm_Advertencia adver = new Frm_Advertencia();
			Frm_Filtro fis = new Frm_Filtro();

			if (lsv_person.SelectedIndices.Count == 0)
			{
				fis.Show();
				adver.Lbl_Msm1.Text = "Seleccione el item que desea copiar";
				adver.ShowDialog();
				fis.Hide();
				return;
			}
			else
			{
				var lsv = lsv_person.SelectedItems[0];
				string xdni = lsv.SubItems[1].Text;

				Clipboard.Clear();
				Clipboard.SetText(xdni.Trim());
			}
		}

		#region "Personal"
		private void ConfiguraListView()
		{
			var lis = lsv_person;
			lis.Columns.Clear();
			lis.Items.Clear();
			lis.View = View.Details;
			lis.GridLines = false;
			lis.FullRowSelect = true;
			lis.Scrollable = true;
			lis.HideSelection = false;

			//configuramos los anchos y nombres de las columnas:
			lis.Columns.Add("Id_Persona", 0, HorizontalAlignment.Left);
			lis.Columns.Add("Dni", 95, HorizontalAlignment.Left);
			lis.Columns.Add("Nombres del Socio", 316, HorizontalAlignment.Left);
			lis.Columns.Add("Direccion", 0, HorizontalAlignment.Left);
			lis.Columns.Add("Correo", 0, HorizontalAlignment.Left);
			lis.Columns.Add("Sex", 0, HorizontalAlignment.Left);
			lis.Columns.Add("Fe Nacim.", 110, HorizontalAlignment.Left);
			lis.Columns.Add("Nro Celular", 120, HorizontalAlignment.Left);
			lis.Columns.Add("Rol", 100, HorizontalAlignment.Left);
			lis.Columns.Add("Distrito", 0, HorizontalAlignment.Left);
			lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);
		}

		private void Cargar_todo_Perosnal()
		{
			RN_Personal obj = new RN_Personal();
			DataTable dt = new DataTable();

			dt = obj.RN_Leer_todoPersona();
			if (dt.Rows.Count > 0)
			{
				//Llamamos al método LlenarListView:
				LlenarListView(dt);
			}
		}

		private void Buscar_Personal_PorValor(string xvalor)
		{
			RN_Personal obj = new RN_Personal();
			DataTable dt = new DataTable();

			dt = obj.RN_Buscar_Personal_xValor(xvalor);
			if (dt.Rows.Count > 0)
			{
				LlenarListView(dt);
			}
			else
			{
				lsv_person.Items.Clear();
			}
		}

		private void LlenarListView(DataTable data)
		{
			lsv_person.Items.Clear();

			for (int i = 0; i < data.Rows.Count; i++)
			{
				DataRow dr = data.Rows[i];
				ListViewItem list = new ListViewItem(dr["Id_Pernl"].ToString());//cabecera del listview
				list.SubItems.Add(dr["DNIPR"].ToString());
				list.SubItems.Add(dr["Nombre_Completo"].ToString());
				list.SubItems.Add(dr["Domicilio"].ToString());
				list.SubItems.Add(dr["Correo"].ToString());
				list.SubItems.Add(dr["Sexo"].ToString());
				list.SubItems.Add(dr["Fec_Naci"].ToString());
				list.SubItems.Add(dr["Celular"].ToString());
				list.SubItems.Add(dr["NomRol"].ToString());

				list.SubItems.Add(dr["Distrito"].ToString());
				list.SubItems.Add(dr["Estado_Per"].ToString());
				lsv_person.Items.Add(list);//Llena el listView
			}
			Lbl_total.Text = Convert.ToString(lsv_person.Items.Count);
		}

		private void Txt_Buscar_OnValueChanged(object sender, EventArgs e)
		{
			if (txt_Buscar.Text.Trim().Length > 2)
			{
				Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
			}
		}

		private void Txt_Buscar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
			}
		}

		private void Bt_mostrarTodoElPersonal_Click(object sender, EventArgs e)
		{
			Cargar_todo_Perosnal();
		}

		private void Bt_nuevoPersonal_Click(object sender, EventArgs e)
		{
			Frm_Filtro fil = new Frm_Filtro();
			Frm_Registro_Personal per = new Frm_Registro_Personal();

			fil.Show();
			per.xedit = false;
			per.ShowDialog();
			fil.Hide();

			if (Convert.ToString(per.Tag) == "")
				return;
			{
				Cargar_todo_Perosnal();
			}
		}
		#endregion

		private void bt_editarPersonal_Click(object sender, EventArgs e)
		{
			Frm_Filtro fil = new Frm_Filtro();
			Frm_Registro_Personal per = new Frm_Registro_Personal();

			if (lsv_person.SelectedIndices.Count == 0)
			{

			}
			else
			{
				var lsv = lsv_person.SelectedItems[0];
				string Idpersona = lsv.SubItems[0].Text;

				fil.Show();
				per.sevaeditar = true;
				per.Buscar_Personal_ParaEditar(Idpersona);
				per.ShowDialog();
				fil.Hide();

				if (Convert.ToString(per.Tag) == "A")
				{
					Cargar_todo_Perosnal();
				}
			}
		}

		private void btn_SaveHorario_Click(object sender, EventArgs e)
		{
			try
			{
				RN_Horario hor = new RN_Horario();
				EN_Horario por = new EN_Horario();
				Frm_Filtro fis = new Frm_Filtro();
				Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
				Frm_Advertencia adver = new Frm_Advertencia();

				por.Idhora = lbl_idHorario.Text;
				por.HoEntrada = dtp_horaIngre.Value;
				por.HoTole = dtp_hora_tolercia.Value;
				por.HoLimite = Dtp_Hora_Limite.Value;
				por.HoSalida = dtp_horaSalida.Value;

				hor.RN_Actualizar_Horario(por);

				if (BD_Horario.saved == true)
				{
					fis.Show();
					ok.Lbl_msm1.Text = "El horario fue Actualizado";
					ok.ShowDialog();
					fis.Hide();

					elTabPage4.Visible = false;
					elTab1.SelectedTabPageIndex = 0;
				}
			}
			catch
			{

			}
		}

		private void CargarHorarios()
		{
			RN_Horario obj = new RN_Horario();
			DataTable data = new DataTable();

			data = obj.RN_Leer_Horarios();
			if (data.Rows.Count == 0) return;

			lbl_idHorario.Text = Convert.ToString(data.Rows[0]["Id_Hor"]);
			dtp_horaIngre.Value = Convert.ToDateTime(data.Rows[0]["HoEntrada"]);
			dtp_horaSalida.Value = Convert.ToDateTime(data.Rows[0]["HoSalida"]);
			dtp_hora_tolercia.Value = Convert.ToDateTime(data.Rows[0]["MiTolrncia"]);
			Dtp_Hora_Limite.Value = Convert.ToDateTime(data.Rows[0]["HoLimite"]);
		}

		private void bt_Config_Click(object sender, EventArgs e)
		{
			elTabPage4.Visible = true;
			elTab1.SelectedTabPageIndex = 3;
			CargarHorarios();
		}
	}
}
