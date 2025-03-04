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
    /// Lógica de interacción para Combo_ADD_DOC.xaml
    /// </summary>
    public partial class Combo_Add_Doc : UserControl
    {
        public static readonly DependencyProperty ComboBoxItemsProperty =
        DependencyProperty.Register("ComboBoxItems", typeof(IEnumerable<object>), typeof(Combo_Add_Doc), new PropertyMetadata(null, OnComboBoxItemsChanged));

        public IEnumerable<object> ComboBoxItems
        {
            get { return (IEnumerable<object>)GetValue(ComboBoxItemsProperty); }
            set { SetValue(ComboBoxItemsProperty, value); }
        }
        public Combo_Add_Doc()
        {
            InitializeComponent();
            DataContext = this;
        }

        private static void OnComboBoxItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Combo_Add_Doc;
            if (control != null)
            {
                control.ComboBoxMerged.ItemsSource = e.NewValue as IEnumerable<object>;
            }
        }
    }
}
