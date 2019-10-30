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
	public partial class Frm_Print_Asisdeldia : Form
	{
		public Frm_Print_Asisdeldia()
		{
			InitializeComponent();
		}

		public string tipoinfo = "";

		private void Frm_Print_Asisdeldia_Load(object sender, EventArgs e)
		{
			if (tipoinfo == "deldia")
			{
				Generar_InformedelDia();
			}
			else if (tipoinfo == "delmes")
			{
				Generar_InformedelMes();
			}
		}

		private void Generar_InformedelDia()
		{
			RN_Asistencia obj = new RN_Asistencia();
			DataTable data = new DataTable();

			data = obj.RN_Ver_Todas_Asistencias_DelDia(Convert.ToDateTime(this.Tag));
			if (data.Rows.Count > 0)
			{
				Rpte_AsistenciasDeldia rpte = new Rpte_AsistenciasDeldia();
				vsr_infodia.ReportSource = rpte;
				rpte.SetDataSource(data);
				rpte.Refresh();
				vsr_infodia.ReportSource = rpte;
			}
		}

		private void Generar_InformedelMes()
		{
			RN_Asistencia obj = new RN_Asistencia();
			DataTable data = new DataTable();

			data = obj.RN_Ver_Todas_Asistencias_DelDia(Convert.ToDateTime(this.Tag));
			if (data.Rows.Count > 0)
			{
				Rpte_AsistenciasDeldia rpte = new Rpte_AsistenciasDeldia();
				vsr_infodia.ReportSource = rpte;
				rpte.SetDataSource(data);
				rpte.Refresh();
				vsr_infodia.ReportSource = rpte;
			}
		}

		private void Pnl_titulo_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Utilitarios u = new Utilitarios();
				u.Mover_formulario(this);
			}
		}

		private void Btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Btn_Imprimir_Click(object sender, EventArgs e)
		{
			vsr_infodia.PrintReport();
		}

		private void Btn_exportar_Click(object sender, EventArgs e)
		{
			vsr_infodia.ExportReport();
		}

		private void Btn_refresh_Click(object sender, EventArgs e)
		{
			vsr_infodia.RefreshReport();
		}
	}
}
