using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for WarningLight.xaml
    /// </summary>
    public partial class WarningLight : UserControl
    {
        public WarningLight()
        {
            InitializeComponent();
        }

        public LightState LightState
        {
            get
            {
                return (LightState)GetValue(LightStateProperty);
            }
            set
            {
                SetValue(LightStateProperty, value);
            }
        }

        private static DependencyProperty LightStateProperty = DependencyProperty.Register(nameof(LightState), typeof(LightState), typeof(WarningLight), new PropertyMetadata(LightState.None, new PropertyChangedCallback(OnStateChanged)));

        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var light = (WarningLight)d;
            light.b1_show.Visibility = Visibility.Visible;
            light.b2_show.Visibility = Visibility.Visible;
            light.b3_show.Visibility = Visibility.Visible;
            light.b1.Visibility = Visibility.Visible;
            light.b2.Visibility = Visibility.Visible;
            light.b3.Visibility = Visibility.Visible;
            switch (light.LightState)
            {
                case LightState.None:
                    light.b1_show.Visibility = Visibility.Collapsed;
                    light.b2_show.Visibility = Visibility.Collapsed;
                    light.b3_show.Visibility = Visibility.Collapsed;
                    break;
                case LightState.Fault:
                    light.b1.Visibility = Visibility.Collapsed;
                    light.b2_show.Visibility = Visibility.Collapsed;
                    light.b3_show.Visibility = Visibility.Collapsed;
                    break;
                case LightState.Warning:
                    light.b1_show.Visibility = Visibility.Collapsed;
                    light.b2.Visibility = Visibility.Collapsed;
                    light.b3_show.Visibility = Visibility.Collapsed;
                    break;
                case LightState.Run:
                    light.b1_show.Visibility = Visibility.Collapsed;
                    light.b2_show.Visibility = Visibility.Collapsed;
                    light.b3.Visibility = Visibility.Collapsed;
                    break;
                default:
                    break;
            }

        }
    }

    public enum LightState
    {
        None, Fault, Warning, Run
    }
}
