using ANDISI_Entidades.TRAMITES;
using ANDISI_Negocio.Clases;
using ANDISI_Negocio.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ANDISI_Negocio.Tramites
{
    public class Vm_Gsi_Bus : ViewModelEntidad
    {
        public ICommand CommandBuscar { get; set; }
        public Vm_Gsi_Bus()
        {
            CommandBuscar = new Relay_Command_Negocio(Buscar_Socio);
        }

        private void Buscar_Socio(object obj)
        {

            MessageBox.Show("buscar socio" + Busqueda.Fecha_Alta);
        }
    }
}
