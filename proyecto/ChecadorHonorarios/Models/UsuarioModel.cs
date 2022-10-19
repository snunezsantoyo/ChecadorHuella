﻿
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ChecadorHonorarios.Models
{
    public static class UsuarioModel
    {
        private static bool editar;
        private static bool verificar;
        
        /*Esta clase estatica se utiliza para guardar los datos de un nuevo usuario */

        public static user Usuario { get; set; } = new user();
        public static fingerprint Huella { get; set; } = new fingerprint();
        public static daysIn DiasLaborales { get; set; } = new daysIn();
        public static schedule Horarios { get; set; } = new schedule();

        public static bool Editar { get; set; } = editar;
        public static bool Verificar { get; set; } = verificar;
        

    }
}
