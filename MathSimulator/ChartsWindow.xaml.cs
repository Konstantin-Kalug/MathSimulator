using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Window mainWindow;
        private Dictionary<string, Grid> actions;
        public ChartsWindow(Window window)
        {
            InitializeComponent();
            mainWindow = window;
            actions = new Dictionary<string, Grid>() {{"Гипотеза Коллатца", CollatzGrid }, {"Формула Таппера", TupperGrid } };
            actionsList_Filling();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            mainWindow.Show();
        }
        private void actionsList_Filling()
        {
            bool flag = false;
            foreach (var elem in actions.Keys)
            {
                actionsList.Items.Add(elem);
                if (!flag) {actionsList.SelectedItem = elem; flag = true;}
            }
        }

        private void actionsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grides_Change((string)((ComboBox)sender).SelectedItem);
        }
        private void grides_Change(string action)
        {
            foreach (var elem in actions.Keys)
            {
                if (elem != action) actions[elem].Visibility = Visibility.Hidden; else actions[elem].Visibility = Visibility.Visible;
            }
        }

        private void numbersBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
        private void get_ChartCollatz() {
            WpfPlot1.Plot.Clear();
            int num;
            int count = 0;
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            if (numbersBox.Text != "" && numbersBox.Text != "0")
            {
                num = Convert.ToInt32(numbersBox.Text);
                while (num != 1) {
                    y.Add(num);
                    x.Add(count);
                    count++;
                    if (num % 2 == 0) num /= 2; else num = 3 * num + 1;
                }
                y.Add(1); x.Add(count);
                double[] dataX = x.ToArray();
                double[] dataY = y.ToArray();
                WpfPlot1.Plot.AddScatter(dataX, dataY);
                WpfPlot1.Refresh();
            }
        }

        private void numbersBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) get_ChartCollatz();
        }
    }
}
