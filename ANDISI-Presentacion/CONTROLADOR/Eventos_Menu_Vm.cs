using ANDISI_Entidades.CONFIGURACION;
using ANDISI_Negocio.Configuracion;
using FontAwesome.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ANDISI_Presentacion
{
    public class Eventos_Menu_Vm : INotifyPropertyChanged
    {
        public ICommand ExpandAllCommand { get; set; }
        public ICommand CerrarSesion { get; set; }
        public ICommand HamburgerCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand IsEmpty { get; set; }
        public ICommand prueba { get; set; }

        private  Main_Window Main_window = null;
        private readonly Login_Andi  Login_window = null;
        private NUsuario _NUsuario = null;
        private bool expand = true;

        public Eventos_Menu_Vm(Main_Window Ventana_Principal)
        {
            ExpandAllCommand = new Relay_Command(ExpandAll);
            CerrarSesion = new Relay_Command(CerrarVentana);
            HamburgerCommand = new Relay_Command(Hamburger);
            this.Main_window = Ventana_Principal;
        }

        public Eventos_Menu_Vm(Login_Andi Ventana_login)
        {
            this.Login_window = Ventana_login;
            LoginCommand = new Relay_Command(Login);
            prueba = new Relay_Command(p);
        }

        public Eventos_Menu_Vm()
        {
            IsEmpty = new Relay_Command(ValidaVacio);
        }

        private void ValidaVacio(object obj)
        {
            MessageBox.Show("VALIDA LOS VACIOS");
        }

        private void p(object obj)
        {
            MessageBox.Show("esta es de GSM");
        }

        private void Login(object obj)
        {
            _NUsuario = new NUsuario();
            IList<EUsuario> DatosUsuario = _NUsuario.RecuperaUsuario(Login_window.txtUsuario.Text, Login_window.txtClave.Password);
            if (DatosUsuario.Count == 1)
            {
                Main_window = new Main_Window(DatosUsuario[0].id_usuario);
                Application.Current.MainWindow = Main_window;
                Main_window.Show();
                Login_window.Close();
            }
            else
            {
                MessageBox.Show("Error en Inicio de Sesión");
            }
        }
        private void Hamburger(object obj)
        {
            var showStoryboard = Main_window.Resources["ShowPanelStoryboard"] as Storyboard;
            var hideStoryboard = Main_window.Resources["HidePanelStoryboard"] as Storyboard;
            if (Main_window.DockMenu.Opacity == 0)
            {
                Main_window.DockMenu.Visibility = Visibility.Visible;
                showStoryboard.Begin();
            }
            else
            {
                hideStoryboard.Completed += (s, a) =>
                {
                    Main_window.DockMenu.Visibility = Visibility.Collapsed;
                };
                hideStoryboard.Begin();
            }
        }

        private void CerrarVentana(object parameter)
        {
            Application.Current.Shutdown();
        }
        private void ExpandAll(object parameter)
        {
            List<Expander> expanders = FindExpanders(Main_window.content_main);
            if (expanders.Count > 0)
            {
                if (expand)
                {
                    foreach (var exp in expanders)
                    {
                        exp.IsExpanded = true;

                    }
                    Main_window.ExpandAllButton.Content = new FontAwesome.WPF.ImageAwesome
                    {
                        Icon = FontAwesomeIcon.Compress,
                        Width = 13,
                        Height = 13,
                        Foreground = Brushes.White
                    };
                    expand = false;
                }
                else
                {
                    foreach (var exp in expanders)
                    {
                        exp.IsExpanded = false;

                    }
                    expand = true;
                    Main_window.ExpandAllButton.Content = new FontAwesome.WPF.ImageAwesome
                    {
                        Icon = FontAwesomeIcon.Expand, 
                        Width = 13,
                        Height = 13,
                        Foreground = Brushes.White
                    };
                }
            }
        }
        private List<Expander> FindExpanders(DependencyObject parent)
        {
            List<Expander> expanders = new List<Expander>();
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is Expander expander)
                {
                    expanders.Add(expander);
                }
                else
                {
                    expanders.AddRange(FindExpanders(child));
                }
            }

            return expanders;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
