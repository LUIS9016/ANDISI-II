using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Menu = ANDISI_Presentacion.VISTAS.Menu;
using ANDISI_Negocio.Clases;

namespace ANDISI_Presentacion
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Main_Window : Window
    {
        public Main_Window(int IdUsuario)
        {
            InitializeComponent();
            Custom_close();
            Scroll_menu.Content = new Menu(IdUsuario);
            DataContext = new Eventos_Menu_Vm(this);
        }

        private void Custom_close()
        {
            Close.MouseEnter += (s, e) =>
            {
                Close.Cursor = Cursors.Hand;
                Close.FontSize = 24;
            };
            Close.MouseLeave += (s, e) =>
            {
                Close.Cursor = Cursors.Arrow;
                Close.FontSize = 17;
            };
        }

    }
}