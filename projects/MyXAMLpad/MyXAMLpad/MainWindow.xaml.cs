using System;
using System.IO;
using System.Windows.Markup;
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

namespace MyXAMLpad
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

        private void btnVievXaml_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("YourXaml.xaml", "txtXamldata.Text");
            Window myWindow = null;
            try
            {
                using (Stream sr = File.Open("YourXaml.xaml", FileMode.Open))
                myWindow = (Window)XamlReader.Load(sr);
                myWindow.ShowDialog();
                myWindow.Close();
                myWindow = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            File.WriteAllText("YourXaml.xaml", txtXamldata.Text);
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("YourXaml.xaml"))
            {
                txtXamldata.Text = File.ReadAllText("YourXaml.xaml");
            }
            else
            { 
                txtXamldata.Text = "< Window  xmlns ";
            }
        }
    }
}
