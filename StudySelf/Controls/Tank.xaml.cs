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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudySelf.Controls
{
    /// <summary>
    /// Interaction logic for Tank.xaml
    /// </summary>
    public partial class Tank : UserControl
    {
        public Tank()
        {
            InitializeComponent();
        }

        public double WaveHeight
        {
            get
            {
                return (double)GetValue(WaveHeightProperty);
            }
            set
            {
                SetValue(WaveHeightProperty, value);
            }
        }

        private static readonly DependencyProperty WaveHeightProperty = DependencyProperty.Register(nameof(WaveHeight), typeof(double), typeof(Tank), new PropertyMetadata(1.0, OnLevelChanged));

        private static void OnLevelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var tank = d as Tank;
            var y = 235 - tank!.WaveHeight / 100 * 235;

            DoubleAnimation da = new DoubleAnimation(y, new TimeSpan(0, 0, 0, 0, 300));
            tank.tank.BeginAnimation(TranslateTransform.YProperty, da);
        }
    }
}
