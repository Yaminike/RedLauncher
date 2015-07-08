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

namespace RedLauncher.Controls
{
    /// <summary>
    /// Interaction logic for CustomProgressBar.xaml
    /// </summary>
    public partial class CustomProgressBar : UserControl
    {
        public double Value
        {
            get { return InnerBar.Value; }
            set { InnerBar.Value = value; }
        }

        public string Text
        {
            get { return InnerText.Text; }
            set { InnerText.Text = value; }
        }
        
        public CustomProgressBar()
        {
            InitializeComponent();
        }
    }
}
