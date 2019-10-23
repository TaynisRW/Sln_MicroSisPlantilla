using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using System.Data;


namespace Prj_Capa_Negocio
{
    public  class RN_Usuario
    {
		public bool RN_Verificar_Acceso(string Usuario, string Contraseña)
		{
			BD_usuario obj = new BD_usuario();
			return obj.BD_Verificar_Acceso(Usuario, Contraseña);
		}




	}
}
