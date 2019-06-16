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

namespace WebServiceClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            localhost.WebService1 obj = new localhost.WebService1();
            label.Content = obj.HelloWorld();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            localhost.WebService1 obj = new localhost.WebService1();
            lblAddResult.Content = obj.Add(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));

        }
    }
}
