using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
  public   class EN_Justificacion
    {



        string _IdJusti;
        string _Id_Personal;
        string _PrincipalMotivo;
        string _Detalle;
        DateTime  _Fecha;
        string _Estado;

        public string IdJusti { get => _IdJusti; set => _IdJusti = value; }
        public string Id_Personal { get => _Id_Personal; set => _Id_Personal = value; }
        public string PrincipalMotivo { get => _PrincipalMotivo; set => _PrincipalMotivo = value; }
        public string Detalle { get => _Detalle; set => _Detalle = value; }
        public DateTime  Fecha { get => _Fecha; set => _Fecha = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
    }
}
