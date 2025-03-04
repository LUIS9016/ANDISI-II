using ANDISI_Entidades.TRAMITES;
using ANDISI_Entidades.CONFIGURACION;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ANDISI_Negocio.Clases
{
    public abstract class ViewModelEntidad : View_Model_Base
    {
        private EBusqueda _busqueda;

        public EBusqueda Busqueda
        {
            get => _busqueda;
            set
            {
                if (_busqueda != value)
                {
                    _busqueda = value;
                    OnPropertyChanged(nameof(Busqueda));
                }
            }
        }
        public ViewModelEntidad()
        {
            this._busqueda = new EBusqueda();
        }

    }
}
