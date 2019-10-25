using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;

namespace Prj_Capa_Negocio
{
   public  class RN_Personal
    {
		public void RN_Registrar_Personal(EN_Persona per)
		{
			BD_Personal obj = new BD_Personal();
			obj.BD_Registrar_Personal(per);
		}

		public void RN_Editar_Personal(EN_Persona per)
		{
			BD_Personal obj = new BD_Personal();
			obj.BD_Editar_Personal(per);
		}

		public void RN_Registrar_Huella_Dactilar_Personal(string idper, object finguer)
		{
			BD_Personal obj = new BD_Personal();
			obj.BD_Registrar_Huella_Dactilar_Personal(idper, finguer);
		}

		public DataTable RN_Leer_todoPersona()
		{
			BD_Personal obj = new BD_Personal();
			return obj.BD_Leer_todoPersona();
		}

		public DataTable RN_Buscar_Personal_xValor(string valor)
		{
			BD_Personal obj = new BD_Personal();
			return obj.BD_Buscar_Personal_xValor(valor);
		}

		public bool RN_Verificar_DniPersonal(string dni)
		{
			BD_Personal obj = new BD_Personal();
			return obj.BD_Verificar_DniPersonal(dni);
		}
	}
}
