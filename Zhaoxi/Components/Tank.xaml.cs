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

namespace Zhaoxi.Configuration.Components
{
    /// <summary>
    /// Tank.xaml 的交互逻辑
    /// </summary>
    public partial class Tank : UserControl
    {
        public double Level
        {
            get { return (double)GetValue(LevelProperty); }
            set { SetValue(LevelProperty, value); }
        }
        public static readonly DependencyProperty LevelProperty =
            DependencyProperty.Register("Level",
                typeof(double),
                typeof(Tank),
                new PropertyMetadata(0.0, new PropertyChangedCallback(OnLevelChanged)));

        private static void OnLevelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var tank = d as Tank;
            var v = 120 - tank.Level / 100 * 120;

            DoubleAnimation da = new DoubleAnimation(v, new TimeSpan(0, 0, 0, 0, 300));
            tank.tt.BeginAnimation(TranslateTransform.YProperty, da);
        }

        public Tank()
        {
            InitializeComponent();
        }
    }
}
