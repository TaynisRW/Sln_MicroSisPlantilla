using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public  class EN_Temporal
    {

        string _Dni;
        string _idAsis;
        DateTime _Fecha;
        string _Tipo;

        public string Dni { get => _Dni; set => _Dni = value; }
        public string IdAsis { get => _idAsis; set => _idAsis = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
    }
}
