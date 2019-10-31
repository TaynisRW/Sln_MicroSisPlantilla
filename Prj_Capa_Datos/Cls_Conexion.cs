using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prj_Capa_Datos
{
   public class Cls_Conexion
    {

        public string Conectar()
        {
			StreamReader leer;
			leer = new StreamReader(@"C:\SystemConnection.txt");
			string linea;
			linea = leer.ReadLine();
			return linea;

            //return @"Data Source=.; Initial Catalog=MicroSisPlani;integrated security=true";
            //return @"Data Source=PC-ADMIN\SQLEXPRESS; Initial Catalog=MicroSisPlani;uid=sa;pwd=admin"; ;
        }

        public static string Conectar2()
        {
			StreamReader leer;
			leer = new StreamReader(@"C:\SystemConnection.txt");
			string linea;
			linea = leer.ReadLine();
			return linea;

			//return @"Data Source=.; Initial Catalog=MicroSisPlani;integrated security=true";
            //return @"Data Source=PC-ADMIN\SQLEXPRESS; Initial Catalog=MicroSisPlani;uid=sa;pwd=admin"; ;
        }

    }
}
