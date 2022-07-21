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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            menuGrid.Visibility = Visibility.Collapsed;
            settingsGrid.Visibility = Visibility.Visible;

        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow;
            if (sender == buttonMenuChart) { newWindow = new ChartsWindow(); }
            else if (sender == buttonMenuGraph) { newWindow = new GraphsWindow(); }
            else if (sender == buttonMenuStatistics) { newWindow = new StatisticsWindow(); }
            else if (sender == buttonMenuRandom) { newWindow = new RandomWindow(); }
            else { newWindow = new InfoWindow(); }
            openNewWindow(newWindow);
        }
        private void openNewWindow(Window window)
        {
            window.Show();
            this.Hide();
        }
    }
}
