using ANDISI_Entidades.Menu;
using ANDISI_Negocio;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;



namespace ANDISI_Presentacion
{
    public class Construccion_Dinamica : UserControl
    {
        private NMenu nMetaData = null;
        private Main_Window main_window = null;
        private Dictionary<string, UserControl> userControlInstances = new Dictionary<string, UserControl>();

        public void Genera_metadata_sf(StackPanel Contenido, int id_submenu)
        {
            IList<EMetaData> eMetaData = Get_metadata(id_submenu);

            foreach (var _data in eMetaData)
            {

                Expander expander = new Expander
                {
                    Header = _data.Nombre,
                    HeaderTemplate = (DataTemplate)FindResource("expander_sf"),
                    Margin = new Thickness(10, 0, 0, 10)
                };

                if (_data.IsExpanded)
                {
                    expander.IsExpanded = true;
                }

                StackPanel stackPanel = new StackPanel();
                Type userControlType = Type.GetType("ANDISI_Presentacion.VISTAS."+_data.RutaUserControl+"." + _data.UserControl);
                if (userControlType != null)
                {
                    UserControl userControlInstance = (UserControl)Activator.CreateInstance(userControlType);
                    stackPanel.Children.Add(userControlInstance);
                }
                expander.Content = stackPanel;
                Contenido.Children.Add(expander);
            }
        }
        public void Genera_MenuDinamico(StackPanel Contenido, int id_menu)
        {
            IList<EMenuDinamico> _datos = get_menu(id_menu);
            var grupo_menu = _datos.GroupBy(_datos => _datos.DescripcionMenu)
                             .Select(group => new
                             {
                                 Descripcion_menu = group.Key,
                                 Count = group.Count()
                             });

            foreach (var menu in grupo_menu)
            {
                Expander expander = new Expander
                {                    
                    Style = (Style)FindResource("CustomExpanderStyle"),
                    Margin = new Thickness(10, 0, 0, 10),
                    FontSize = 18

                };
                AccessText accessText = new AccessText {
                    Text = "➣ _" + menu.Descripcion_menu,
                    Style = (Style)FindResource("acces-lbl-white")
                };
                expander.Header = accessText;
                expander.MouseEnter += (s, e) =>
                {
                    expander.Cursor = Cursors.Hand;
                };
                expander.MouseLeave += (s, e) =>
                {
                    expander.Cursor = Cursors.Arrow;
                };

                StackPanel stackPanel = new StackPanel();
                var item_filtrado = _datos.Where(item => item.DescripcionMenu == menu.Descripcion_menu).ToList();
                foreach (var submenus in item_filtrado)
                {
                    Button btnSubmenu = new Button
                    {
                        Foreground = new SolidColorBrush(Colors.White),
                        Margin = new Thickness(35, 5, 0, 5),
                        Name = submenus.AccionForm,
                        FontSize = 16,
                        Tag = submenus.idSubmenuIten,
                        BorderThickness = new Thickness(0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        CommandParameter = submenus.Ruta,
                        Style = (Style)FindResource("btn-submenu")
                    };
                    AccessText accessTextsub = new AccessText();
                    accessTextsub.Text = "_" + submenus.DescripcionSubmenu;
                    
                    btnSubmenu.Content = accessTextsub;
                    stackPanel.Children.Add(btnSubmenu);
                    btnSubmenu.Click += SubMenu_Click;
                }
                expander.Content = stackPanel;
                Contenido.Children.Add(expander);
            }
        }
        private IList<EMetaData> Get_metadata(int id_submenu)
        {
            nMetaData = new NMenu();
            var metadata = nMetaData.RecuperaMetaData(id_submenu);
            return metadata;
        }

        private IList<EMenuDinamico> get_menu(int id_usuario)
        {
            nMetaData = new NMenu();
            var DatosMenu = nMetaData.RecuperaMenu(id_usuario);
            return DatosMenu;
        }

        private void SubMenu_Click(object sender, RoutedEventArgs e)
        {

            Button clickedSubMenu = sender as Button;
            string formName = clickedSubMenu.Name;
            string rutaUser = clickedSubMenu.CommandParameter as string;
            int id_submenu = Convert.ToInt32(clickedSubMenu.Tag);
            ActualizaContenido(formName, id_submenu,rutaUser,clickedSubMenu);
            clickedSubMenu.Style = (Style)FindResource("btn-submenu");

        }
        private void ActualizaContenido(string formName,int id_submenu,string rutaUser,Button btn_submenu){

            main_window = Application.Current.MainWindow as Main_Window;
            SetBgBtn(main_window.Scroll_menu as DependencyObject);
            btn_submenu.Background = Brushes.Purple;
            Type userControlType = Type.GetType("ANDISI_Presentacion.VISTAS."+rutaUser+"." + formName);
            if (userControlType != null)
            {
                if (!userControlInstances.TryGetValue(formName, out UserControl userControlInstance))
                {
                    userControlInstance = (UserControl)Activator.CreateInstance(userControlType, id_submenu);
                    userControlInstances.Add(formName, userControlInstance);
                }
                main_window.content_main.Content = userControlInstance;
            }
            else
            {
                MessageBox.Show("En construcción", "Información", MessageBoxButton.OK, MessageBoxImage.Information);

                return;
            }
        }

        private void SetBgBtn(DependencyObject ObjContent)
        {
            int TotalBtn = VisualTreeHelper.GetChildrenCount(ObjContent);
            for (int i = 0; i < TotalBtn; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(ObjContent, i);
                if (child is Button button)
                {
                    button.Background = Brushes.Transparent;
                }
                SetBgBtn(child); 
            }
        }
    }


}
