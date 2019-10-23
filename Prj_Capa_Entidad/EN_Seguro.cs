using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public  class EN_Seguro
    {

        string _Id_Seguro;
        string _Nombre_Seguro;
        double _Aporte_Obligtorio;
        double _Comision_Ra;
        double _Prima_Seguro;

        public string Id_Seguro { get => _Id_Seguro; set => _Id_Seguro = value; }
        public string Nombre_Seguro { get => _Nombre_Seguro; set => _Nombre_Seguro = value; }
        public double Aporte_Obligtorio { get => _Aporte_Obligtorio; set => _Aporte_Obligtorio = value; }
        public double Comision_Ra { get => _Comision_Ra; set => _Comision_Ra = value; }
        public double Prima_Seguro { get => _Prima_Seguro; set => _Prima_Seguro = value; }
    }
}
