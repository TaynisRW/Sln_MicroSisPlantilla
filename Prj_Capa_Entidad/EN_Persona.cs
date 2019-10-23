using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public  class EN_Persona
    {

        string _idpersonal;
        string _dni;

        string _Nombres;
        DateTime _añoNacmnto;
        string _sexo;
        string _Direccion;
        string _Correo;
        string _Id_Seguro;
        int _Celular;
        string _distritoID;
        string _idrol;
        string _imagen;
        string _estado;
        Single _FinguerPrint;



        public Single FinfuerPrint
        {
            get { return _FinguerPrint; }
            set { _FinguerPrint = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string xImagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        public string IdRol
        {
            get { return _idrol; }
            set { _idrol = value; }
        }
        
        public string IdDistrito
        {
            get { return _distritoID; }
            set { _distritoID = value; }
        }

        public int Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }

        public string IdSeguro
        {
            get { return _Id_Seguro; }
            set { _Id_Seguro = value; }
        }

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        public string Idpersonal
        {
            get { return _idpersonal; }
            set { _idpersonal = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public DateTime anoNacimiento
        {
            get { return _añoNacmnto; }
            set { _añoNacmnto = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }



    }
}
