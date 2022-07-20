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

        private void buttonMenuChart_Click(object sender, RoutedEventArgs e)
        {
            ChartsWindow chartsWindow = new ChartsWindow();
            chartsWindow.Show();
        }

        private void buttonMenuGraph_Click(object sender, RoutedEventArgs e)
        {
            GraphsWindow graphsWindow = new GraphsWindow();
            graphsWindow.Show();
        }

        private void buttonMenuStatistics_Click(object sender, RoutedEventArgs e)
        {
            StatisticsWindow statisticsWindow = new StatisticsWindow();
            statisticsWindow.Show();
        }

        private void buttonMenuInfo_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
        }
    }
}
