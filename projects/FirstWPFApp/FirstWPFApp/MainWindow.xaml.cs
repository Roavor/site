using System;
using System.Windows;
using System.Windows.Controls;


namespace FirstWPFApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public  class Program : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
           
        }
        static void AppExit(object sender,ExitEventArgs e)
        {
            MessageBox.Show("App has exited");
        }
        static void AppStartUp(object sender,StartupEventArgs e)
        {
            Window mainWindow = new Window();
            mainWindow.Title = "My first WPF App";  
            mainWindow.Height = 200;
            mainWindow.Width = 300;
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();
        }
    }
}
