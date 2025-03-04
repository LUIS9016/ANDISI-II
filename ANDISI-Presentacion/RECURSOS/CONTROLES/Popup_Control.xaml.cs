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

namespace ANDISI_Presentacion.RECURSOS.CONTROLES
{
    /// <summary>
    /// Lógica de interacción para PopupControl.xaml
    /// </summary>
    public partial class Popup_Control : UserControl
    {
        public Popup_Control()
        {
            InitializeComponent();
        }

        private void ClosePopup_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
    }
}