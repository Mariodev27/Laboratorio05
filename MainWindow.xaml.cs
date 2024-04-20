using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Laboratorio05
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

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            // Crear una nueva instancia de la ventana Create
            var createWindow = new Create();
            // Mostrar la ventana Create
            createWindow.Show();
        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            // Crear una nueva instancia de la ventana Read
            var readWindow = new Read();
            // Mostrar la ventana Create
            readWindow.Show();

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            // Crear una nueva instancia de la ventana Update
            var updateWindow = new Update();
            // Mostrar la ventana Create
            updateWindow.Show();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Crear una nueva instancia de la ventana Delete
            var deleteWindow = new Delete();
            // Mostrar la ventana Create
            deleteWindow.Show();

        }
    }
}
