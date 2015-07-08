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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using NotifyIcon = System.Windows.Forms.NotifyIcon;

namespace RedLauncher.Controls
{
    /// <summary>
    /// Interaction logic for CustomWindow.xaml
    /// </summary>
    [ContentProperty("CustomContent")]
    public partial class CustomWindow : UserControl
    {
        public object CustomContent
        {
            get { return contentControl.Content; }
            set { contentControl.Content = value; }
        }

        private NotifyIcon TrayIcon { get; set; }

        public CustomWindow()
        {
            InitializeComponent();

            TrayIcon = new NotifyIcon()
            {
                Icon = RedLauncher.Properties.Resources.MapleLeaf,
                BalloonTipText = "Click here to open the launcher again"
            };

            Action show = () =>
            {
                (Parent as Window).Show();
                TrayIcon.Visible = false;
            };

            MouseLeftButtonDown += (s, e) => (Parent as Window).DragMove();
            TrayIcon.Click += (s, e) => show();
            TrayIcon.BalloonTipClicked += (s, e) => show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            (Parent as Window).Close();
            TrayIcon.Visible = false;
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            TrayIcon.Visible = true;
            (Parent as Window).Hide();
            TrayIcon.ShowBalloonTip(1000);
        }
    }
}
