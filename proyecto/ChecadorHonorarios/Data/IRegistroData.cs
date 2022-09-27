using ChecadorHonorarios.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecadorHonorarios.Data
{
    internal interface IRegistroData
    {
    
         RegistrarUsuarioController Get();


         void Set(RegistrarUsuarioController RUController);
       
    }
}
