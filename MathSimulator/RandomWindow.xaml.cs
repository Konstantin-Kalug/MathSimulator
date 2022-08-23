﻿using System;
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
    /// Логика взаимодействия для RandomWindow.xaml
    /// </summary>
    public partial class RandomWindow : Window
    {
        Window mainWindow;
        public RandomWindow(Window window)
        {
            InitializeComponent();
            mainWindow = window;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            mainWindow.Show();
        }
    }
}
