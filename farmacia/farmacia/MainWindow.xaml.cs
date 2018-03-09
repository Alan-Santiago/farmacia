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

namespace farmacia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregarInformacion_Click(object sender, RoutedEventArgs e)
        {
            agregar_informacion ventana = new agregar_informacion();
            ventana.Owner = this;
            ventana.ShowDialog();
        }
    

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            venta ventana = new venta();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
        Close();
    }
    }
}
