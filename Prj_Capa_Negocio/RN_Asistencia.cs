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
	}
}
