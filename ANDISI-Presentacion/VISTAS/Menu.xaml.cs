using System.Windows.Controls;


namespace ANDISI_Presentacion.VISTAS
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        private Construccion_Dinamica Cmenu = new Construccion_Dinamica();

        public Menu(int id_user)
        {
            InitializeComponent();
            Cmenu.Genera_MenuDinamico(StackDinamico,id_user);
        }
    }
}
