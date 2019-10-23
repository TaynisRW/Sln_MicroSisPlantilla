using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroSisPlani
{
public	class Cls_Libreria
	{
		//public  struct  SesionUsuario
		//{
		//	public static string  IdUsu;
		//	public  string Usuario;
		//	public static string Nombres;
		//	public string Apellidos;
		//	public string  IdRol;
		//	public string Rol;
		//	public string Foto;
		//}

		//public SesionUsuario ObjSesionUsuario;



        private static string _idUsu;
        private static string usuario;
        //private static string _nombres;
        private static string apellidos;
        private static string idRol;
        private static string rol;
        private static string foto;

       
        public static string IdUsu { get => _idUsu; set => _idUsu = value; }
        public static string Usuario { get => usuario; set => usuario = value; }
      
        public static string Apellidos { get => apellidos; set => apellidos = value; }
        public static string Foto { get => foto; set => foto = value; }
        public static  string Rol { get => rol; set => rol = value; }
        public static string IdRol { get => idRol; set => idRol = value; }
        //public static string xNombres { get => _nombres; set => _nombres = value; }
    }
}
