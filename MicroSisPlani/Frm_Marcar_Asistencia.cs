using DPFP;
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
using Prj_Capa_Negocio;
using Prj_Capa_Datos;
using MicroSisPlani.Msm_Forms;
using System.IO;

namespace MicroSisPlani
{
    public partial class Frm_Marcar_Asistencia : Form
    {
        public Frm_Marcar_Asistencia()
        {
            InitializeComponent();

        }

		private void Frm_Marcar_Asistencia_Load(object sender, EventArgs e)
		{
			Verificar = new DPFP.Verification.Verification();
			Resultado = new DPFP.Verification.Verification.Result();
			CargarHorarios();
		}

		private DPFP.Verification.Verification Verificar;
		private DPFP.Verification.Verification.Result Resultado;


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

		private void xVerificationControl_OnComplete(object Control, FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
		{
			//DPFP.Template TemplateBD = new DPFP.Template();
			RN_Personal obj = new RN_Personal();
			RN_Asistencia objas = new RN_Asistencia();
			DataTable datosPersona = new DataTable();
			DataTable dataAsis = new DataTable();

			//byte[] finguerByte;
			string NroIDPersona = "";
			int xitn = 1;
			byte[] fingerByte;
			string rutaFoto;
			bool TerminarBucle = false;
			int totalFila = 0;
			Frm_Filtro fil = new Frm_Filtro();

			int HoLimite = Dtp_Hora_Limite.Value.Hour;
			int MiLimite = Dtp_Hora_Limite.Value.Minute;

			int horaCaptu = DateTime.Now.Hour;
			int minutoCaptu = DateTime.Now.Minute;

			try
			{
				datosPersona = obj.RN_Leer_todoPersona();
				totalFila = datosPersona.Rows.Count;
				if (datosPersona.Rows.Count <= 0) return;

				var datoPer = datosPersona.Rows[0];
				foreach (DataRow xitem in datosPersona.Rows)
				{
					if (TerminarBucle == true) return;

					fingerByte = (byte[])xitem["FinguerPrint"];
					NroIDPersona = Convert.ToString(xitem["Id_Pernl"]);

					DPFP.Template TemplateBD = new DPFP.Template();

					TemplateBD.DeSerialize(fingerByte);

					Verificar.Verify(FeatureSet, TemplateBD, ref Resultado);

					if (Resultado.Verified == true)
					{
						rutaFoto = Convert.ToString(xitem["Foto"]);
						lbl_nombresocio.Text = Convert.ToString(xitem["Nombre_Completo"]);
						Lbl_Idperso.Text = Convert.ToString(xitem["Id_Pernl"]);
						lbl_Dni.Text = Convert.ToString(xitem["DNIPR"]);

						if (File.Exists(rutaFoto) == true) { picSocio.Load(rutaFoto.Trim()); } else { picSocio.Load(Application.StartupPath + @"\user.png"); }

						if (objas.RN_Checar_SiPersonal_YaMarco_Asistencia(Lbl_Idperso.Text.Trim()) == true)
						{
							lbl_msm.BackColor = Color.MistyRose;
							lbl_msm.ForeColor = Color.Red;
							lbl_msm.Text = "El sistema verificó que el personal ya marcó su asistencia";
							tocar_timbre();
							lbl_Cont.Text = "10";
							xVerificationControl.Enabled = true;
							pnl_Msm.Visible = true;
							tmr_Conta.Enabled = true;
							return;
						}

						if (objas.RN_Checar_SiPersonal_YaMarco_Entrada(Lbl_Idperso.Text.Trim()) == true)
						{
							Frm_Sinox sino = new Frm_Sinox();
							TerminarBucle = true;
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
									xVerificationControl.Enabled = false;
									pnl_Msm.Visible = true;

									lbl_Cont.Text = "10";
									tmr_Conta.Enabled = true;

									TerminarBucle = true;
								}
							}
							else
							{
								LimpiarFormulario();
								sec = 10;
								tmr_Conta.Stop();
								pnl_Msm.Visible = false;
								xVerificationControl.Enabled = true;
								lbl_Cont.Text = "10";
							}
						}
						else
						{
							//entonces marcar entrada
							if (horaCaptu >= HoLimite)
							{
								lbl_msm.BackColor = Color.MistyRose;
								lbl_msm.ForeColor = Color.Red;
								lbl_msm.Text = "Estimado usuario, su hora de entrada ya caducó. Vuelve a casa y regresa mañana";
								tocar_timbre();
								pnl_Msm.Visible = true;
								tmr_Conta.Enabled = true;

								lbl_Cont.Text = "10";
								xVerificationControl.Enabled = false;
								return;
							}

							calcular_Minutos_Tardanza();
							lbl_IdAsis.Text = RN_Utilitario.RN_NroDoc(3);
							objas.RN_Registrar_Entrada_Personal(lbl_IdAsis.Text, Lbl_Idperso.Text, lbl_hora.Text, Convert.ToDouble(lbl_totaltarde.Text), Convert.ToInt32(lbl_TotalHotrabajda.Text), lbl_justifi.Text);
							if (BD_Asistencia.entrada == true)
							{
								RN_Utilitario.RN_Actualiza_Tipo_Doc(3);
								lbl_msm.BackColor = Color.YellowGreen;
								lbl_msm.ForeColor = Color.White;
								lbl_msm.Text = "La entrada del personal fue registrada exitosamente";
								tocar_timbreOK();
								pnl_Msm.Visible = true;
								tmr_Conta.Enabled = true;
								xVerificationControl.Enabled = false;
								lbl_Cont.Text = "10";
								TerminarBucle = true;
							}
						}
					}
					else
					{
						if (xitn == totalFila)
						{
							if (TerminarBucle == false)
							{
								lbl_msm.BackColor = Color.MistyRose;
								lbl_msm.ForeColor = Color.Red;
								lbl_msm.Text = "La Huella Dactilar no existe en la base de datos";
								tocar_timbre();
								lbl_Cont.Text = "10";
								pnl_Msm.Visible = true;
								tmr_Conta.Enabled = true;
								xVerificationControl.Enabled = false;
							}
						}
					}
					xitn += 1;
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
				xVerificationControl.Enabled = true;
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
			xVerificationControl.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
		}
	}
}
