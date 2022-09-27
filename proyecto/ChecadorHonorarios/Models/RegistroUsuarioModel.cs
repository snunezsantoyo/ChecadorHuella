
using System;
using System.Collections;

namespace ChecadorHonorarios.Models
{
    public static class RegistroUsuarioModel
    {           
        public static user Usuario { get; set; } = new user();
        public static fingerprint Huella { get; set; } = new fingerprint();
        public static daysIn DiasLaborales { get; set; } = new daysIn();
        public static schedule Horarios { get; set; } = new schedule(); 

    }
}
