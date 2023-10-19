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

namespace s07dp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int propietat 
        { 
            get { return (int)GetValue(laMevaPropietat); }
            set { SetValue(laMevaPropietat, value); }
        }
        public static readonly DependencyProperty laMevaPropietat =
            DependencyProperty.Register("propietat", typeof (int), typeof(MainWindow), new PropertyMetadata(0));
        public MainWindow()
        {
            InitializeComponent();
        }

    }
}
