using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Entidad;
using Prj_Capa_Datos;
using System.Data.SqlClient;
namespace Prj_Capa_Negocio
{
  public   class RN_Distrito
    {

        public DataTable RN_Buscar_Todos_Distrito()
        {
            BD_Distrito obj = new BD_Distrito();
            return obj.BD_Buscar_Todos_Distrito();
        }

    }
}
