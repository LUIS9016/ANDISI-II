using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ANDISI_Presentacion.VISTAS.DOCUMENTACION.AUS
{
    /// <summary>
    /// Lógica de interacción para AUS.xaml
    /// </summary>
    public partial class Aus_Doc : UserControl
    {
        private Construccion_Dinamica Cmenu = new Construccion_Dinamica();
        public Aus_Doc(int id_submenu)
        {
            InitializeComponent();
            Cmenu.Genera_metadata_sf(Contenido_dinamico, id_submenu);
        }
    }
}
