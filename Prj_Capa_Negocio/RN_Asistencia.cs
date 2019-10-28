using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Datos;
using System.Data;

namespace Prj_Capa_Negocio
{
	public class RN_Asistencia
	{
		public DataTable RN_Ver_Todas_Asistencias()
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Ver_Todas_Asistencias();
		}

		public DataTable RN_Ver_Todas_Asistencias_DelDia(DateTime xdia)
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Ver_Todas_Asistencias_DelDia(xdia);
		}

		public DataTable RN_Ver_Todas_Asistencias_DelMes(DateTime xfecha)
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Ver_Todas_Asistencias_DelMes(xfecha);
		}

		public DataTable RN_Ver_Todas_Asistencias_ParaExplorador(string xvalor)
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Ver_Todas_Asistencias_ParaExplorador(xvalor);
		}

		public void RN_Registrar_Entrada_Personal(string idAsis, string idPerso, string HoIngreso, double tarde, int TotalHora, string justificado)
		{
			BD_Asistencia obj = new BD_Asistencia();
			obj.BD_Registrar_Entrada_Personal(idAsis, idPerso, HoIngreso, tarde, TotalHora, justificado);
		}

		public void RN_Registrar_Salida_Personal(string idAsis, string idPerso, string HoSalida, double Totalhora)
		{
			BD_Asistencia obj = new BD_Asistencia();
			obj.BD_Registrar_Salida_Personal(idAsis, idPerso, HoSalida, Totalhora);
		}

		public bool RN_Checar_SiPersonal_YaMarco_Asistencia(string xidPerso)
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Checar_SiPersonal_YaMarco_Asistencia(xidPerso);
		}

		public bool RN_Checar_SiPersonal_YaMarco_Entrada(string xidPerso)
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Checar_SiPersonal_YaMarco_Entrada(xidPerso);
		}

		public bool RN_Verificar_Justificacion_Aprobada(string idPers)
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Verificar_Justificacion_Aprobada(idPers);
		}

		public DataTable RN_Buscar_Asistencia_deEntrada(string idperso)
		{
			BD_Asistencia obj = new BD_Asistencia();
			return obj.BD_Buscar_Asistencia_deEntrada(idperso);
		}
	}
}
