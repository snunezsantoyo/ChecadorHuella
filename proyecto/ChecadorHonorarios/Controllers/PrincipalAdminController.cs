using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios.Controllers
{
    public static class PrincipalAdminController
    {
        public static bool CancelarProceso { get; set; }    
        public static Form CambioInfo_Cerrar { get; set; }
        public static Form CambioInfo_Hide { get; set; }
        public static bool LimpiarPanel { get; set; }

        /* Para el manejo de los estados en la pantalla principal necesitamos controlar 
         * los 4 estados distintos que podemos tener, para esto usaremos dos variables,
         * y controlaremos la maquina de estados de la siguiente manera: 
        *   Metodo    (CloseForm, HideForm)   Descripcion 
        *   INIT        (0, 0)              -> Cuando la pantalla esta vacia al inicio y mostramos el menu default 
        *   CLOSE       (1, 0)              -> Cuando cerramos una pantalla 
        *   HIDE        (0, 1)              -> Cuando escondemos una pantalla 
        *   SHOW        (1, 1)              -> Cuando queremos mostrar una pantalla que esta escondida
        
        */

        public static bool HideForm { get; set; }   

        public static bool CloseForm { get; set; }  

        public static void EstadoForm_Set(String estado)
        {
            switch (estado)
            {
                case "INIT":
                    CloseForm = false;
                    HideForm = false;
                   
                    break;
                case "CLOSE":                   
                    CloseForm = true;
                    HideForm = false;
                    break;
                case "HIDE":
                    CloseForm = false;
                    HideForm = true;
                    break;
                case "SHOW":
                    CloseForm = true;
                    HideForm = true;
                    break;
                default:
                    break;
            }
        }
    
     public static string EstadoCheckUsuario { get; set; }


    }
}
