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
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            menuGrid.Visibility = Visibility.Collapsed;
            settingsGrid.Visibility = Visibility.Visible;

        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window;
            if (sender == buttonMenuChart) { window = new ChartsWindow(this); }
            else if (sender == buttonMenuGraph) { window = new GraphsWindow(this); }
            else if (sender == buttonMenuStatistics) { window = new StatisticsWindow(this); }
            else if (sender == buttonMenuRandom) { window = new RandomWindow(this); }
            else { window = new InfoWindow(this); }
            openNewWindow(window);
        }
        private void openNewWindow(Window window) { window.Show(); if (!(window is InfoWindow)) this.Hide(); }
    }
}
