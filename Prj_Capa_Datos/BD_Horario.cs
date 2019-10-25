using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Prj_Capa_Entidad;

namespace Prj_Capa_Datos
{
  public   class BD_Horario : Cls_Conexion 
    {
		public static bool saved = false;

		public void BD_Actualizar_Horario(EN_Horario P)
		{
			SqlConnection cn = new SqlConnection();
			SqlCommand cmd = new SqlCommand();
			try
			{
				cn.ConnectionString = Conectar();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Sp_Update_Horario";
				cmd.Connection = cn;
				cmd.CommandTimeout = 20;
				//Agregar parámetros
				cmd.Parameters.AddWithValue("@Idhor", P.Idhora);
				cmd.Parameters.AddWithValue("@HoEntrada", P.HoEntrada);
				cmd.Parameters.AddWithValue("@HoTolere", P.HoTole);
				cmd.Parameters.AddWithValue("@Holimite", P.HoLimite);
				cmd.Parameters.AddWithValue("@HoraSalida", P.HoSalida);
				cn.Open();
				cmd.ExecuteNonQuery();
				cn.Close();
				cmd.Dispose();
				cmd = null;
				cn.Dispose();
				cn = null;

				saved = true;
				//MessageBox.Show("El horario se ha modificado Exitosamente", "Informe de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				saved = false;
				MessageBox.Show("Hubo un error al editar el horario" + ex.Message, "Informe de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (cn.State == ConnectionState.Open) cn.Close();
				cmd.Dispose();
				cmd = null;
				cn.Dispose();
				cn = null;
			}
		}

		public DataTable BD_Leer_Horarios()
		{
			SqlConnection Cn = new SqlConnection();
			try
			{
				Cn.ConnectionString = Conectar();
				SqlDataAdapter Da = new SqlDataAdapter("Sp_Buscar_Todos_Horarios", Cn);
				Da.SelectCommand.CommandType = CommandType.StoredProcedure;
				//Da.SelectCommand.Parameters.AddWithValue("@Id_Ped", Id)
				DataTable Datos = new DataTable();
				Da.Fill(Datos);
				Da = null;
				return Datos;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hay un error al consultar el horario" + ex.Message, "Informe de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (Cn.State == ConnectionState.Open) Cn.Close();
				Cn.Dispose();
				Cn = null;
				return null;
			}
		}







    }
}
