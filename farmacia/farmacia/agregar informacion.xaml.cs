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
using System.Windows.Shapes;

namespace farmacia
{
    /// <summary>
    /// Lógica de interacción para agregar_informacion.xaml
    /// </summary>
    public partial class agregar_informacion : Window
    {
        public agregar_informacion()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {
            categoria ventana1 = new categoria();
            ventana1.Owner = this;
            ventana1.ShowDialog();
        }

        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {
            producto ventana1 = new producto();
            ventana1.Owner = this;
            ventana1.ShowDialog();
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            cliente ventana1 = new cliente();
            ventana1.Owner = this;
            ventana1.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, RoutedEventArgs e)
        {
            empleado ventana1 = new empleado();
            ventana1.Owner = this;
            ventana1.ShowDialog();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
    }
}
