using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;

namespace Prj_Capa_Negocio
{
  public   class RN_Utilitario
    {
		public static string RN_NroDoc(int Id_Tipo)
		{
			return BD_Utilitario.BD_NroDoc(Id_Tipo);
		}

		public static void RN_Actualiza_Tipo_Doc(int Id_Tipo)
		{
			BD_Utilitario.BD_Actualiza_Tipo_Doc(Id_Tipo);
		}



	}
}
