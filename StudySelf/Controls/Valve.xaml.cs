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

namespace StudySelf.Controls
{
    /// <summary>
    /// Interaction logic for Valve.xaml
    /// </summary>
    public partial class Valve : UserControl
    {
        public Valve()
        {
            InitializeComponent();
        }

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
    DependencyProperty.Register("IsOpen",
        typeof(bool), typeof(Valve),
        new PropertyMetadata(false, new PropertyChangedCallback(OnIsOpenChanged)));

        private static void OnIsOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var valve = (d as Valve);
            valve!.sw.Angle = !valve.IsOpen ? 0 : -90;
        }
    }
}
