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
   public  class RN_Rol
    {

        public DataTable RN_Buscar_Todos_Roles()
        {
            BD_Rol obj = new BD_Rol();
            return obj.BD_Buscar_Todos_Roles();
        }

    }
}
