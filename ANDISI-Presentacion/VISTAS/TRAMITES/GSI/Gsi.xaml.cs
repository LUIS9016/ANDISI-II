using ANDISI_Negocio.Tramites;
using System.Windows.Controls;

namespace ANDISI_Presentacion.VISTAS.TRAMITES.GSI
{
    /// <summary>
    /// Lógica de interacción para GSI.xaml
    /// </summary>
    public partial class Gsi : UserControl
    {
        private Construccion_Dinamica Cmenu = new Construccion_Dinamica();
        public Gsi(int id_submenu)
        {
            InitializeComponent();
            Cmenu.Genera_metadata_sf(Contenido_dinamico,id_submenu);
        }
    }
}
