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
using System.Windows.Shapes;

namespace Dagadu_Generator
{
    /// <summary>
    /// Interaction logic for about.xaml
    /// </summary>
    public partial class about : Elysium.Controls.Window
    {
        public about()
        {
            InitializeComponent();
        }

        private void kembali(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

    }
}
