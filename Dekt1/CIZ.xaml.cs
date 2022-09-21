using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Dekt1
{
    /// <summary>
    /// Логика взаимодействия для CIZ.xaml
    /// </summary>
    public partial class CIZ : Page
    {
        public CIZ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://app.roboflow.com/varya/hard-hat-sample-gchv4/1");
        }
    }
}
