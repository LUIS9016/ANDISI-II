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
    /// Lógica de interacción para Label_Add.xaml
    /// </summary>
    public partial class Label_Add : UserControl
    {
        public static readonly DependencyProperty TextProperty =
                       DependencyProperty.Register("Text", typeof(string), typeof(Label_Add), new PropertyMetadata(string.Empty));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Label_Add()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
