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
using System.Windows.Shapes;

namespace MathSimulator
{
    /// <summary>
    /// Логика взаимодействия для ChartsWindow.xaml
    /// </summary>
    public partial class ChartsWindow : Window
    {
        Window mainWindow;
        public ChartsWindow(Window window)
        {
            InitializeComponent();
            mainWindow = window;
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { mainWindow.Show(); this.Hide(); }
    }
}
