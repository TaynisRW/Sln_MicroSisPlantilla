using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public  class EN_TipoDoc
    {

        int _idItpo;
        string _nomDoc;
        string _Serie;
        string _numero;
        string _estado;

        public int IdItpo { get => _idItpo; set => _idItpo = value; }
        public string NomDoc { get => _nomDoc; set => _nomDoc = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Estado { get => _estado; set => _estado = value; }
    }
}
