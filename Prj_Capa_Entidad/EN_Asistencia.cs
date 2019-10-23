using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public class EN_Asistencia
    {

        string _idAsistencia;
        string _Id_Personal;
        DateTime _FechaAsi;
        string _HoraIngre;
        string _HoraSalida;
        int _Tardanza;
        int _Mntos_Extra;
                     double _TotalHoras;
        string _Justificacion;
        double _Adelanto;

        string _identificador;
        string _Nombre_Dia;
        string _estado_Asi;

        public string IdAsistencia { get => _idAsistencia; set => _idAsistencia = value; }
        public string Id_Personal { get => _Id_Personal; set => _Id_Personal = value; }
        public DateTime FechaAsi { get => _FechaAsi; set => _FechaAsi = value; }
        public string HoraIngre { get => _HoraIngre; set => _HoraIngre = value; }
        public string HoraSalida { get => _HoraSalida; set => _HoraSalida = value; }
        public int Tardanza { get => _Tardanza; set => _Tardanza = value; }
        public int Mntos_Extra { get => _Mntos_Extra; set => _Mntos_Extra = value; }
        public double TotalHoras { get => _TotalHoras; set => _TotalHoras = value; }
        public string Justificacion { get => _Justificacion; set => _Justificacion = value; }
        public double Adelanto { get => _Adelanto; set => _Adelanto = value; }
        public string Identificador { get => _identificador; set => _identificador = value; }
        public string Nombre_Dia { get => _Nombre_Dia; set => _Nombre_Dia = value; }
        public string Estado_Asi { get => _estado_Asi; set => _estado_Asi = value; }
    }
}
