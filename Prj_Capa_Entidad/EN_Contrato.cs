using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public  class EN_Contrato
    {

        string  _IdContrato;
        string _Id_Prsonal;
        DateTime _fecha_emi;
        DateTime _FechaIni;
        DateTime _FechaFin;
        string   _Tipo_contrato;
        string _Days_worked;
        string  _Day_toRest;
        string _Has_Vacation;
        string  _Has_AsigFamily;
        string _Has_Gratifi;
        string  _Pay_Rent_5ta_Catg;
        double  _Sueldo_Fijo;
        string _Acept_termn;
        string  _State_Deal;
        string _Id_Security;

        public string IdContrato { get => _IdContrato; set => _IdContrato = value; }
        public string Id_Prsonal { get => _Id_Prsonal; set => _Id_Prsonal = value; }
        public DateTime Fecha_emi { get => _fecha_emi; set => _fecha_emi = value; }
        public DateTime FechaIni { get => _FechaIni; set => _FechaIni = value; }
        public DateTime FechaFin { get => _FechaFin; set => _FechaFin = value; }
        public string Tipo_contrato { get => _Tipo_contrato; set => _Tipo_contrato = value; }
        public string Days_worked { get => _Days_worked; set => _Days_worked = value; }
        public string Day_toRest { get => _Day_toRest; set => _Day_toRest = value; }
        public string Has_Vacation { get => _Has_Vacation; set => _Has_Vacation = value; }
        public string Has_AsigFamily { get => _Has_AsigFamily; set => _Has_AsigFamily = value; }
        public string Has_Gratifi { get => _Has_Gratifi; set => _Has_Gratifi = value; }
        public string Pay_Rent_5ta_Catg { get => _Pay_Rent_5ta_Catg; set => _Pay_Rent_5ta_Catg = value; }
        public double Sueldo_Fijo { get => _Sueldo_Fijo; set => _Sueldo_Fijo = value; }
        public string Acept_termn { get => _Acept_termn; set => _Acept_termn = value; }
        public string State_Deal { get => _State_Deal; set => _State_Deal = value; }
        public string Id_Security { get => _Id_Security; set => _Id_Security = value; }
    }
}
