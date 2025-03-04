using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para ListCheck.xaml
    /// </summary>
    /// 

    public class Item
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }

    public partial class List_Check : UserControl
    {
        public ObservableCollection<Item> Items { get; set; }

        public List_Check()
        {
            InitializeComponent();
                Items = new ObservableCollection<Item>
                {
                new Item { Name = "Item 1" },
                new Item { Name = "Item 2" },
                new Item { Name = "Item 3" }
                };
            this.DataContext = this;
        }
    }
}
