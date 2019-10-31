using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Entidad;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
  public class BD_Personal : Cls_Conexion 
  {

		public static bool saved = false;
		public static bool edited = false;

		public void BD_Registrar_Personal(EN_Persona per)
		{
			SqlConnection cn = new SqlConnection(Conectar());
			SqlCommand cmd = new SqlCommand("Sp_Insert_Personal", cn);
			try
			{
				cmd.CommandTimeout = 20;
				cmd.CommandType = CommandType.StoredProcedure;
				//Se agregan los parámetros de nuestro procedimiento almacenado
				cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
				cmd.Parameters.AddWithValue("@dni", per.Dni);
				cmd.Parameters.AddWithValue("@nombreComplto", per.Nombres);
				cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
				cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
				cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
				cmd.Parameters.AddWithValue("@Correo", per.Correo);
				cmd.Parameters.AddWithValue("@Celular", per.Celular);
				cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
				cmd.Parameters.AddWithValue("@Foto", per.xImagen);
				cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);

				cn.Open();
				cmd.ExecuteNonQuery();
				cn.Close();

				saved = true;
			}
			catch (Exception ex)
			{
				saved = false;
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				MessageBox.Show("Algo malo pasó" + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}//fin

		//Método para editar los datos del personal: 
		public void BD_Editar_Personal(EN_Persona per)
		{
			SqlConnection cn = new SqlConnection(Conectar());
			SqlCommand cmd = new SqlCommand("SP_UPDATE_PERSONAL", cn);
			try
			{
				cmd.CommandTimeout = 20;
				cmd.CommandType = CommandType.StoredProcedure;
				//Se agregan los parámetros de nuestro procedimiento almacenado
				cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
				cmd.Parameters.AddWithValue("@dni", per.Dni);
				cmd.Parameters.AddWithValue("@nombreComplto", per.Nombres);
				cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
				cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
				cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
				cmd.Parameters.AddWithValue("@Correo", per.Correo);
				cmd.Parameters.AddWithValue("@Celular", per.Celular);
				cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
				cmd.Parameters.AddWithValue("@Foto", per.xImagen);
				cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);

				cn.Open();
				cmd.ExecuteNonQuery();
				cn.Close();

				edited = true;
			}
			catch (Exception ex)
			{
				edited = false;
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				MessageBox.Show("Algo malo pasó" + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}//fin

		public static bool huella = false;
		
		//Método para registrar Huella Dactilar del personal:
		public void BD_Registrar_Huella_Dactilar_Personal(string idper,	object finguer)
		{
			SqlConnection cn = new SqlConnection(Conectar());
			SqlCommand cmd = new SqlCommand("Sp_Actualizar_FinguerPrint", cn);

			try
			{
				cmd.CommandTimeout = 20;
				cmd.CommandType = CommandType.StoredProcedure;

				//parámetros del SP
				cmd.Parameters.AddWithValue("@IdPersona", idper);
				cmd.Parameters.AddWithValue("@finguerPrint", finguer);

				cn.Open();
				cmd.ExecuteNonQuery();
				cn.Close();

				huella = true;
			}
			catch (Exception ex)
			{
				huella = false;
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		//Método para leer a todo el personal registrado
		public DataTable BD_Leer_todoPersona()
		{
			SqlConnection cn = new SqlConnection();
			try
			{
				cn.ConnectionString = Conectar();
				SqlDataAdapter da = new SqlDataAdapter("SP_Listar_Personal", cn);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				DataTable dato = new DataTable();

				da.Fill(dato);
				da = null;
				return dato;
			}
			catch (Exception ex)
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return null;
		}

		//Método para la búsqueda de personal por Nombre o ID
		public DataTable BD_Buscar_Personal_xValor(string valor)
		{
			SqlConnection cn = new SqlConnection();
			try
			{
				cn.ConnectionString = Conectar();
				SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_PersonalxDni", cn);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@Dni", valor);
				DataTable dato = new DataTable();

				da.Fill(dato);
				da = null;
				return dato;
			}
			catch (Exception ex)
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return null;
		}

		public bool BD_Verificar_DniPersonal(string dni)
		{
			bool functionReturnValue = false;
			Int32 xfil = 0;

			SqlConnection Cn = new SqlConnection();
			SqlCommand Cmd = new SqlCommand();
			Cn.ConnectionString = Conectar();

			var _with1 = Cmd;

			_with1.CommandText = "Sp_Validar_Dni";
			_with1.Connection = Cn;
			_with1.CommandTimeout = 20;
			_with1.CommandType = CommandType.StoredProcedure;
			_with1.Parameters.AddWithValue("@Dni", dni);
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
		} //fin de verificar 1

		public static bool supresed = false;

		public void BD_Eliminar_Personal(string idperson)
		{
			SqlConnection cn = new SqlConnection(Conectar());
			SqlCommand cmd = new SqlCommand("Sp_Eliminar_Personal", cn);

			try
			{
				cmd.CommandTimeout = 20;
				cmd.CommandType = CommandType.StoredProcedure;

				//agregamos los parámetros
				cmd.Parameters.AddWithValue("@dni", idperson);

				cn.Open();
				cmd.ExecuteNonQuery();
				cn.Close();

				supresed = true;
			}
			catch (Exception ex)
			{
				supresed = false;
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
