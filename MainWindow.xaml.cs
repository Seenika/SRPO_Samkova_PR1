﻿using System;
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

namespace SRPO_Samkova_PR1
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

        private void Pust1_Click(object sender, RoutedEventArgs e)
        {
            Pust1.Content = "0";
        }

        private void Pust2_Click(object sender, RoutedEventArgs e)
        {
            Pust2.Content = "1";
        }

        private void Pust3_Click(object sender, RoutedEventArgs e)
        {
            Pust3.Content = "0";
        }

        private void Pust4_Click(object sender, RoutedEventArgs e)
        {
            Pust4.Content = "0";
        }

        private void Pust5_Click(object sender, RoutedEventArgs e)
        {
            Pust5.Content = "х____х";
            MessageBox.Show("Ты здох, тут мина, сочувствую TvT");
        }

        private void Pust6_Click(object sender, RoutedEventArgs e)
        {
            Pust6.Content = "1";
        }

        private void Pust7_Click(object sender, RoutedEventArgs e)
        {
            Pust7.Content = "0";
        }

        private void Pust8_Click(object sender, RoutedEventArgs e)
        {
            Pust8.Content = "0";
        }

        private void Pust9_Click(object sender, RoutedEventArgs e)
        {
            Pust9.Content = "0";
        }

        private void Pust10_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("НЕ ТРОГАЙ! Здесь ничего нет. >:[");

        }

    }
}
