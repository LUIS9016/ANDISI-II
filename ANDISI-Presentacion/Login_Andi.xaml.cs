
using System.Windows;
using System.Windows.Input;


namespace ANDISI_Presentacion
{
    /// <summary>
    /// Lógica de interacción para LoginAndi.xaml
    /// </summary>
    public partial class Login_Andi : Window
    {
        public Login_Andi()
        {
            InitializeComponent();
            DataContext = new Eventos_Menu_Vm(this);
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }

}
