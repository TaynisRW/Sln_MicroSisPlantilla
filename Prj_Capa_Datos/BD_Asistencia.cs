using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
	public class BD_Asistencia : Cls_Conexion
	{
		public DataTable BD_Ver_Todas_Asistencias()
		{
			SqlConnection xcn = new SqlConnection();
			try
			{
				xcn.ConnectionString = Conectar();
				SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Todas_Asistencias", xcn);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				//da.SelectCommand.Parameters.AddWithValue("@fecha", xdia);
				DataTable Dato = new DataTable();

				da.Fill(Dato);
				da = null;
				return Dato;
			}
			catch (Exception ex)
			{
				if (xcn.State == ConnectionState.Open)
				{
					xcn.Close();
					throw new Exception("Error" + ex.Message, ex);
				}
			}
			return null;
		}

		public DataTable BD_Ver_Todas_Asistencias_DelDia(DateTime xdia)
		{
			SqlConnection xcn = new SqlConnection();
			try
			{
				xcn.ConnectionString = Conectar();
				SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_deldia", xcn);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@fecha", xdia);
				DataTable Dato = new DataTable();

				da.Fill(Dato);
				da = null;
				return Dato;
			}
			catch (Exception ex)
			{
				if (xcn.State == ConnectionState.Open)
				{
					xcn.Close();
					throw new Exception("Error" + ex.Message, ex);
				}
			}
			return null;
		}

		public DataTable BD_Ver_Todas_Asistencias_DelMes(DateTime xfecha)
		{
			SqlConnection xcn = new SqlConnection();
			try
			{
				xcn.ConnectionString = Conectar();
				SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_xFecha", xcn);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@fecha", xfecha);
				DataTable Dato = new DataTable();

				da.Fill(Dato);
				da = null;
				return Dato;
			}
			catch (Exception ex)
			{
				if (xcn.State == ConnectionState.Open)
				{
					xcn.Close();
					throw new Exception("Error" + ex.Message, ex);
				}
			}
			return null;
		}

		public DataTable BD_Ver_Todas_Asistencias_ParaExplorador(string xvalor)
		{
			SqlConnection xcn = new SqlConnection();
			try
			{
				xcn.ConnectionString = Conectar();
				SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Asistencia_paraExplorador", xcn);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@Id_Asis", xvalor);
				DataTable Dato = new DataTable();

				da.Fill(Dato);
				da = null;
				return Dato;
			}
			catch (Exception ex)
			{
				if (xcn.State == ConnectionState.Open)
				{
					xcn.Close();
					throw new Exception("Error" + ex.Message, ex);
				}
			}
			return null;
		}

		public DataTable BD_Buscar_Asistencia_deEntrada(string idperso)
		{
			SqlConnection xcn = new SqlConnection();
			try
			{
				xcn.ConnectionString = Conectar();
				SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_asistencia_reciente", xcn);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@idper", idperso);
				DataTable Dato = new DataTable();
				da.Fill(Dato);
				da = null;
				return Dato;
			}
			catch (Exception ex)
			{
				if (xcn.State == ConnectionState.Open)
				{
					xcn.Close();
				}
				MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return null;
		}

		public static bool entrada = false;
		public static bool salida = false;

		//Registro de Asistencia de Personal
		public void BD_Registrar_Entrada_Personal(string idAsis, string idPerso, string HoIngreso, double tarde, int TotalHora, string justificado)
		{
			SqlConnection cn = new SqlConnection(Conectar());
			SqlCommand cmd = new SqlCommand("Sp_Registrar_Entrada", cn);

			try
			{
				cmd.CommandTimeout = 20;
				cmd.CommandType = CommandType.StoredProcedure;

				//agregar los parámetros
				cmd.Parameters.AddWithValue("@IdAsis", idAsis);
				cmd.Parameters.AddWithValue("@Id_Persol", idPerso);
				cmd.Parameters.AddWithValue("@Hoingre", HoIngreso);
				cmd.Parameters.AddWithValue("@tardanza", tarde);
				cmd.Parameters.AddWithValue("@TotalHora", TotalHora);
				cmd.Parameters.AddWithValue("@justificado", justificado);

				cn.Open();
				cmd.ExecuteNonQuery();
				cn.Close();

				entrada = true;
			}
			catch (Exception ex)
			{
				entrada = false;
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				throw new Exception("Error al guardar" + ex.Message, ex);
			}
		}

		public void BD_Registrar_Salida_Personal(string idAsis, string idPerso, string HoSalida, double Totalhora)
		{
			SqlConnection cn = new SqlConnection(Conectar());
			SqlCommand cmd = new SqlCommand("Sp_Registrar_Salida", cn);

			try
			{
				cmd.CommandTimeout = 20;
				cmd.CommandType = CommandType.StoredProcedure;

				//agregar los parámetros
				cmd.Parameters.AddWithValue("@IdAsis", idAsis);
				cmd.Parameters.AddWithValue("@Id_Personal", idPerso);
				cmd.Parameters.AddWithValue("@HoSalida", HoSalida);
				cmd.Parameters.AddWithValue("@TotalHora", Totalhora); ;

				cn.Open();
				cmd.ExecuteNonQuery();
				cn.Close();

				salida = true;
			}
			catch (Exception ex)
			{
				salida = false;
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				throw new Exception("Error al guardar" + ex.Message, ex);
			}
		}

		//Verificaciones de Asistencia
		public bool BD_Checar_SiPersonal_YaMarco_Asistencia(string xidPerso)
		{
			bool functionReturnValue = false;
			Int32 xfil = 0;

			SqlConnection Cn = new SqlConnection();
			SqlCommand Cmd = new SqlCommand();
			Cn.ConnectionString = Conectar();
			var _with1 = Cmd;
			_with1.CommandText = "Sp_Validar_RegistroAsistencia";
			_with1.Connection = Cn;
			_with1.CommandTimeout = 20;
			_with1.CommandType = CommandType.StoredProcedure;
			_with1.Parameters.AddWithValue("@Id_Personal", xidPerso);

			try
			{
				Cn.Open();
				xfil = (Int32)Cmd.ExecuteScalar();
				if (xfil > 0)
				{
					functionReturnValue = true;
				}
				else
				{
					functionReturnValue = false;
				}

				Cmd.Parameters.Clear();
				Cmd.Dispose();
				Cmd = null;
				Cn.Close();
				Cn = null;
			}
			catch (Exception ex)
			{
				if (Cn.State == ConnectionState.Open)
					Cn.Close();
				Cmd.Dispose();
				Cmd = null;
				Cn.Close();
				Cn = null;
				MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw
			}
			return functionReturnValue;
		}

		public bool BD_Checar_SiPersonal_YaMarco_Entrada(string xidPerso)
		{
			bool functionReturnValue = false;
			Int32 xfil = 0;

			SqlConnection Cn = new SqlConnection();
			SqlCommand Cmd = new SqlCommand();
			Cn.ConnectionString = Conectar();
			var _with1 = Cmd;
			_with1.CommandText = "Sp_verificar_IngresoAsis";
			_with1.Connection = Cn;
			_with1.CommandTimeout = 20;
			_with1.CommandType = CommandType.StoredProcedure;
			_with1.Parameters.AddWithValue("@Id_Personal", xidPerso);

			try
			{
				Cn.Open();
				xfil = (Int32)Cmd.ExecuteScalar();
				if (xfil > 0)
				{
					functionReturnValue = true;
				}
				else
				{
					functionReturnValue = false;
				}

				Cmd.Parameters.Clear();
				Cmd.Dispose();
				Cmd = null;
				Cn.Close();
				Cn = null;
			}
			catch (Exception ex)
			{
				if (Cn.State == ConnectionState.Open)
					Cn.Close();
				Cmd.Dispose();
				Cmd = null;
				Cn.Close();
				Cn = null;
				MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw
			}
			return functionReturnValue;
		}

		public bool BD_Verificar_Justificacion_Aprobada(string idPers)
		{
			bool functionReturnValue = false;
			Int32 xfil = 0;

			SqlConnection Cn = new SqlConnection();
			SqlCommand Cmd = new SqlCommand();
			Cn.ConnectionString = Conectar();
			var _with1 = Cmd;
			_with1.CommandText = "SP_VerificarJustificacion_Aprobada";
			_with1.Connection = Cn;
			_with1.CommandTimeout = 20;
			_with1.CommandType = CommandType.StoredProcedure;
			_with1.Parameters.AddWithValue("@Id_Personal", idPers);

			try
			{
				Cn.Open();
				xfil = (Int32)Cmd.ExecuteScalar();
				if (xfil > 0)
				{
					functionReturnValue = true;
				}
				else
				{
					functionReturnValue = false;
				}

				Cmd.Parameters.Clear();
				Cmd.Dispose();
				Cmd = null;
				Cn.Close();
				Cn = null;
			}
			catch (Exception ex)
			{
				if (Cn.State == ConnectionState.Open)
					Cn.Close();
				Cmd.Dispose();
				Cmd = null;
				Cn.Close();
				Cn = null;
				MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw
			}
			return functionReturnValue;
		}

		


	}
}
