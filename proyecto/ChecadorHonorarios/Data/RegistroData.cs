using ChecadorHonorarios.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecadorHonorarios.Data
{
    internal class RegistroData : IRegistroData
    {
        private RegistrarUsuarioController RUController = new RegistrarUsuarioController();


        public RegistrarUsuarioController Get()
        {
            return RUController;    
        }

        public void Set (RegistrarUsuarioController RUController)
        {
            this.RUController = RUController;   
        }
    }
}
