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
using System.Data.SqlClient;
using System.Configuration;

namespace WpfConnectionToSQL
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
            var settings = new ConnectionStringSettings
            {
                Name = "Myconnection_1",
                ConnectionString = @"Data sourse=.\SQLEXPRESS; Initial Catalog=EvelDB; Integrated Security=True;"
            };
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("NameOfConnection","SomeConnection"));
            config.Save();
            MessageBox.Show("file is saved");
            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;
            if (section.SectionInformation.IsProtected)
            {
                section.SectionInformation.UnprotectSection();
            }
            else
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            config.Save();
            MessageBox.Show("Protected= "+section.SectionInformation.IsProtected.ToString());

            /*SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = @".\SQLEXPRESS";
            connectionStringBuilder.InitialCatalog = "EvelDB";
            MessageBox.Show(connectionStringBuilder.ConnectionString);
            connectionStringBuilder.UserID = userName.Text;
            connectionStringBuilder.Password = userPassword.Text;
            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection opened to" + connection.Database);
                }
                catch (Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
            }*/
        }
    }
}
