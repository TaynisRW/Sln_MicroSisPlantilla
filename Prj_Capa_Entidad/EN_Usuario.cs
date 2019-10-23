using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
   public  class EN_Usuario
    {

        string _Idusu;
        string _Namecomplete;
        string _Adress;
        string _Avatar;
        string _UsuName;
        string _Password;

        public string Idusu { get => _Idusu; set => _Idusu = value; }
        public string Namecomplete { get => _Namecomplete; set => _Namecomplete = value; }
        public string Adress { get => _Adress; set => _Adress = value; }
        public string Avatar { get => _Avatar; set => _Avatar = value; }
        public string UsuName { get => _UsuName; set => _UsuName = value; }
        public string Password { get => _Password; set => _Password = value; }
    }
}
