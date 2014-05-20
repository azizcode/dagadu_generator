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

namespace Dagadu_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Elysium.Controls.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (plain.Text.Equals("")) {
                MessageBox.Show("Maaf Plain Text Belum Anda Isi");
            }
            else
            {
                chiper.Text = generator.generate(plain.Text);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            chiper.Text = ""; plain.Text = "";
        }

        private void about(object sender, RoutedEventArgs e)
        {
            new about().Show();
            this.Close();
        }
    }
}
