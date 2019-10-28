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
   public  class BD_Utilitario : Cls_Conexion 
    {
		public static string BD_NroDoc(int Id_Tipo)
		{
			SqlConnection Cn = new SqlConnection();
			try
			{
				Cn.ConnectionString = Conectar2();
				SqlCommand cmd = new SqlCommand("Sp_Listado_Tipo", Cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
				string NroDoc;

				Cn.Open();
				NroDoc = Convert.ToString(cmd.ExecuteScalar());
				Cn.Close();
				return NroDoc;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
				if (Cn.State == ConnectionState.Open) Cn.Close();
				Cn.Dispose();
				Cn = null;
				return null;
			}
		}

		public static void BD_Actualiza_Tipo_Doc(int Id_Tipo)
		{
			SqlConnection Cn = new SqlConnection(Conectar2());
			SqlCommand Cmd = new SqlCommand("Sp_Actualiza_Tipo_Doc", Cn);
			try
			{
				Cmd.CommandTimeout = 20;
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
				Cn.Open();
				Cmd.ExecuteNonQuery();
				Cn.Close();

				Cmd.Dispose();
				Cmd = null;
				Cn = null;
			}
			catch (Exception ex)
			{
				if (Cn.State == ConnectionState.Open) Cn.Close();
				Cmd.Dispose();
				Cmd = null;
				MessageBox.Show("Algo salió mal: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
     




    }
}
