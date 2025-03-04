using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANDISI_Datos;
using ANDISI_Entidades.CONFIGURACION;

namespace ANDISI_Negocio.Configuracion
{
    public class NUsuario
    {

        private readonly DUsuario dUsuario = null;

        public NUsuario()
        {

            dUsuario=new DUsuario();

        }
      
        public IList<EUsuario> RecuperaUsuario(string pUserName, string pUsuarioPwd)
        {
            return dUsuario.RecuperaUsuario(pUserName, pUsuarioPwd);
        }



    }
}
