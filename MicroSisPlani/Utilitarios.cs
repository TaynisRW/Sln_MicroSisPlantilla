using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MicroSisPlani
{
    class Utilitarios
    {

        [DllImport ("user32.dll", EntryPoint="ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport ("User32.dll", EntryPoint= "SendMessage")]

        public static extern void  SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int Lparam);

        public void Mover_formulario(Form f)
        {
            ReleaseCapture();
            SendMessage(f.Handle, 0x112, 0xf012, 0);
        }

        public int Solo_Letras(int Teclas)
        {
            
                   
            switch (Teclas) 
            {
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                case 70:
                case 71:
                case 72:
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                case 78:
                case 79:
                case 80:
                case 81:

                case 82:
                case 83:
                case 84:
                case 85:
                case 86:
                case 87:
                case 88:
                case 89:
                case 90:
                case 97:
                case 98:
                case 99:
                case 100:
                case 101:
                case 102:
                case 103:
                case 104:
                case 105:
                case 106:
                case 107:
                case 108:
                case 109:
                case 110:
                case 111:
                case 112:
                case 113:
                case 114:
                case 115:
                case 116:
                case 117:
                case 118:
                case 119:
                case 120:
                case 121:
                case 122:
                    
                case 8:
                case 164:
                case 165:
                case 32:
                case 241: //ñ minuscula
                case 209: //Ñ mayuscula
                case 237: //i con tilde
                case 233:
                case 44:
                    
                    return Teclas  ;
                default :
                    MessageBox.Show("No se Permite Numeros", "Advertencia de Validacfion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   break;


            }
            return Teclas =0 ;


        }


    }
}
