using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using Prj_Capa_Datos;
using MicroSisPlani.Msm_Forms;
using System.IO;




namespace MicroSisPlani
{
    public partial class Frm_Marcar_Asis_Manual : Form
    {
        public Frm_Marcar_Asis_Manual()
        {
            InitializeComponent();
        }

        private void Frm_Marcar_Asis_Manual_Load(object sender, EventArgs e)
        {
			CargarHorarios();
			txt_dni_Buscar.Focus();
        }

		private void CargarHorarios()
		{
			RN_Horario obj = new RN_Horario();
			DataTable data = new DataTable();

			data = obj.RN_Leer_Horarios();
			if (data.Rows.Count == 0) return;
			dtp_horaIngre.Value = Convert.ToDateTime(data.Rows[0]["HoEntrada"]);
			Lbl_HoraEntrada.Text = dtp_horaIngre.Value.Hour.ToString() + ":" + dtp_horaIngre.Value.Minute.ToString();
			dtp_horaSalida.Value = Convert.ToDateTime(data.Rows[0]["HoSalida"]);
			dtp_hora_tolercia.Value = Convert.ToDateTime(data.Rows[0]["MiTolrncia"]);
			Dtp_Hora_Limite.Value = Convert.ToDateTime(data.Rows[0]["HoLimite"]);
		}

		private void Btn_buscar_Click(object sender, EventArgs e)
		{
			RN_Personal obj = new RN_Personal();
			RN_Asistencia objas = new RN_Asistencia();
			DataTable datosPersona = new DataTable();
			DataTable dataAsis = new DataTable();
			Frm_Filtro fil = new Frm_Filtro();
			Frm_Advertencia adver = new Frm_Advertencia();

			string NroIDPersona;
			int cont = 1;
			string rutaFoto;

			int HoLimite = Dtp_Hora_Limite.Value.Hour;
			int MiLimite = Dtp_Hora_Limite.Value.Minute;

			int horaCaptu = DateTime.Now.Hour;
			int minutoCaptu = DateTime.Now.Minute;

			try
			{
				datosPersona = obj.RN_Buscar_Personal_xValor(txt_dni_Buscar.Text.Trim());
				if (datosPersona.Rows.Count <= 0)
				{
					lbl_msm.BackColor = Color.MistyRose;
					lbl_msm.ForeColor = Color.Red;
					lbl_msm.Text = "El número de DNI ingresado no existe o el personal está dado de baja";
					tocar_timbre();
					lbl_Cont.Text = "10";
					pnl_Msm.Visible = true;
					tmr_Conta.Enabled = true;
					return;
				}
				else
				{
					var dt = datosPersona.Rows[0];
					rutaFoto = Convert.ToString(dt["Foto"]);
					lbl_nombresocio.Text = Convert.ToString(dt["Nombre_Completo"]);
					lbl_Dni.Text = Convert.ToString(dt["DNIPR"]);
					NroIDPersona = Convert.ToString(dt["Id_Pernl"]);
					Lbl_Idperso.Text = Convert.ToString(dt["Id_Pernl"]);

					if (File.Exists(rutaFoto) == true)
					{
						picSocio.Load(rutaFoto.Trim());
					}
					else
					{
						picSocio.Load(Application.StartupPath + @"\user.png");
					}

					if (objas.RN_Checar_SiPersonal_YaMarco_Asistencia(Lbl_Idperso.Text) == true)
					{
						lbl_msm.BackColor = Color.MistyRose;
						lbl_msm.ForeColor = Color.Red;
						lbl_msm.Text = "El sistema verificó que el personal ya marcó su entrada y su salida";
						tocar_timbre();
						lbl_Cont.Text = "10";
						pnl_Msm.Visible = true;
						tmr_Conta.Enabled = true;
						return;
					}
					else if (objas.RN_Checar_SiPersonal_YaMarco_Entrada(Lbl_Idperso.Text.Trim()) == true)
					{
						//Toca Marcar su Salida
						Frm_Sinox sino = new Frm_Sinox();
						fil.Show();
						sino.Lbl_msm1.Text = "El usuario ya tiene registrada su entrada, ¿Te gustarìa marcar su salida?";
						sino.ShowDialog();
						fil.Hide();

						if (Convert.ToString(sino.Tag) == "Si")
						{
							dataAsis = objas.RN_Buscar_Asistencia_deEntrada(Lbl_Idperso.Text);
							if (dataAsis.Rows.Count < 1) return;
							lbl_IdAsis.Text = Convert.ToString(dataAsis.Rows[0]["Id_asis"]);
							objas.RN_Registrar_Salida_Personal(lbl_IdAsis.Text, Lbl_Idperso.Text, lbl_hora.Text, 8);
							if (BD_Asistencia.salida == true)
							{
								lbl_msm.BackColor = Color.YellowGreen;
								lbl_msm.ForeColor = Color.White;
								lbl_msm.Text = "La salida del personal fue registrada exitosamente";
								tocar_timbreOK();
								pnl_Msm.Visible = true;
								lbl_Cont.Text = "10";
								tmr_Conta.Enabled = true;
							}
						}
						else
						{
							LimpiarFormulario();
							sec = 10;
							tmr_Conta.Stop();
							pnl_Msm.Visible = false;
							lbl_Cont.Text = "10";
						}
					}
					else
					{
						//Toca Marcar su Entrada
						if (horaCaptu >= HoLimite)
						{
							lbl_msm.BackColor = Color.MistyRose;
							lbl_msm.ForeColor = Color.Red;
							lbl_msm.Text = "Estimado usuario, su hora de entrada ya caducó. Has llegado demasiado tarde";
							tocar_timbre();
							lbl_Cont.Text = "10";
							pnl_Msm.Visible = true;
							tmr_Conta.Enabled = true;
							return;
						}
						//Está en tiempo para marcar su entrada
						calcular_Minutos_Tardanza();
						lbl_IdAsis.Text = RN_Utilitario.RN_NroDoc(3);
						objas.RN_Registrar_Entrada_Personal(lbl_IdAsis.Text, Lbl_Idperso.Text, lbl_hora.Text, Convert.ToDouble(lbl_totaltarde.Text), Convert.ToInt32(lbl_TotalHotrabajda.Text), lbl_justifi.Text);
						if (BD_Asistencia.entrada == true)
						{
							RN_Utilitario.RN_Actualiza_Tipo_Doc(3);
							lbl_msm.BackColor = Color.YellowGreen;
							lbl_msm.ForeColor = Color.White;
							lbl_msm.Text = "La entrada del personal fue registrada exitosamente";
							tocar_Bienvenida();
							pnl_Msm.Visible = true;
							tmr_Conta.Enabled = true;
							lbl_Cont.Text = "10";
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		void calcular_Minutos_Tardanza()
		{
			RN_Asistencia obj = new RN_Asistencia();

			int horaCaptu = DateTime.Now.Hour;
			int minutoCaptu = DateTime.Now.Minute;

			int horaIn = dtp_horaIngre.Value.Hour;
			int MinuIn = dtp_horaIngre.Value.Minute;

			int Mntotole = dtp_hora_tolercia.Value.Minute;

			int totalMinutofijo;
			int totalTardanza;

			if (obj.RN_Verificar_Justificacion_Aprobada(Lbl_Idperso.Text) == true)
			{
				lbl_justifi.Text = "Tardanza Justificada";
			}
			else
			{
				lbl_justifi.Text = "Tardanza no Justificada";
				totalMinutofijo = MinuIn + Mntotole;

				if (horaCaptu == horaIn & minutoCaptu > totalMinutofijo)
				{
					totalTardanza = minutoCaptu - totalMinutofijo;
					lbl_totaltarde.Text = Convert.ToString(totalTardanza);
				}
				else if (horaCaptu > horaIn)
				{
					int horaTarde;
					horaTarde = horaCaptu - horaIn;
					int HoraenMinuto;
					HoraenMinuto = horaTarde * 60;
					int totaltardexx = HoraenMinuto - totalMinutofijo;

					totalTardanza = minutoCaptu + totaltardexx;
					lbl_totaltarde.Text = Convert.ToString(totalTardanza);
				}
			}
		}

		private void tocar_Bienvenida()
		{
			string ruta;
			ruta = Application.StartupPath;
			System.Media.SoundPlayer son;
			son = new System.Media.SoundPlayer(ruta + @"\Bienvenido.wav");
			son.Play();
		}

		private void tocar_timbre()
		{
			string ruta;
			ruta = Application.StartupPath;
			System.Media.SoundPlayer son;
			son = new System.Media.SoundPlayer(ruta + @"\timbre1.wav");
			son.Play();
		}

		private void tocar_timbreOK()
		{
			string ruta;
			ruta = Application.StartupPath;
			System.Media.SoundPlayer son;
			son = new System.Media.SoundPlayer(ruta + @"\SD_ALERT_43.wav");
			son.Play();
		}

		private int sec = 10;
		private void tmr_Conta_Tick(object sender, EventArgs e)
		{
			sec -= 1;
			lbl_Cont.Text = sec.ToString();
			lbl_Cont.Refresh();

			if (sec == 0)
			{
				LimpiarFormulario();
				sec = 10;
				tmr_Conta.Stop();
				pnl_Msm.Visible = false;
				lbl_Cont.Text = "10";
			}
		}

		private void LimpiarFormulario()
		{
			lbl_nombresocio.Text = "";
			lbl_totaltarde.Text = "0";
			lbl_TotalHotrabajda.Text = "0";
			lbl_Dni.Text = "";
			lbl_IdAsis.Text = "";
			Lbl_Idperso.Text = "";
			lbl_justifi.Text = "";
			lbl_msm.BackColor = Color.Transparent;
			lbl_msm.Text = "";
			picSocio.Image = null;
			txt_dni_Buscar.Text = "";
		}

		private void Btn_Salir_Click(object sender, EventArgs e)
		{
			this.Tag = "";
			this.Close();
		}

		private void Pnl_titulo_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Utilitarios u = new Utilitarios();
				u.Mover_formulario(this);
			}
		}

		private void Txt_dni_Buscar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Btn_buscar_Click(sender, e);
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
		}
	}
}
