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

namespace MathSimulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window[] windows = new Window[5];
        public MainWindow()
        {
            InitializeComponent();
            windows[0] = new ChartsWindow(this); windows[1] = new GraphsWindow(this); windows[2] = new StatisticsWindow(this); windows[3] = new RandomWindow(this); windows[4] = new InfoWindow(this);
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            menuGrid.Visibility = Visibility.Collapsed;
            settingsGrid.Visibility = Visibility.Visible;

        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            int key;
            if (sender == buttonMenuChart) { key = 0; }
            else if (sender == buttonMenuGraph) { key = 1; }
            else if (sender == buttonMenuStatistics) { key = 2; }
            else if (sender == buttonMenuRandom) { key = 3; }
            else { key = 4; }
            openNewWindow(windows[key]);
        }
        private void openNewWindow(Window window)
        {
            window.Show();
            this.Hide();
        }
    }
}
