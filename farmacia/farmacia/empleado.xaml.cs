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
    /// Lógica de interacción para empleado.xaml
    /// </summary>
    public partial class empleado : Window
    {
        RepositorioDeEmpleado repoempleado;
        bool esNuevo;
        public empleado()
        {
            InitializeComponent();
            repoempleado = new RepositorioDeEmpleado();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dtgTabla.ItemsSource = null;
            dtgTabla.ItemsSource = repoempleado.LeerEmpleados();
        }

        private void HabilitarBotones(bool habilitados)
        {
            btnNuevo.IsEnabled = habilitados;
            btnEditar.IsEnabled = habilitados;
            btnEliminar.IsEnabled = habilitados;
            btnGuardar.IsEnabled = !habilitados;
            btnCancelar.IsEnabled = !habilitados;
        }

        private void HabilitarCajas(bool habilitadas)
        {
            txbNombre.Clear();
            txbDireccion.Clear();            
            txbTelefono.Clear();
            txbCorreo.Clear();
            txbArea.Clear();
            txbNombre.IsEnabled = habilitadas;
            txbDireccion.IsEnabled = habilitadas;
            txbTelefono.IsEnabled = habilitadas;
            txbCorreo.IsEnabled = habilitadas;
            txbArea.IsEnabled = habilitadas;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbDireccion.Text) || string.IsNullOrEmpty(txbTelefono.Text) || string.IsNullOrEmpty(txbCorreo.Text) || string.IsNullOrEmpty(txbArea.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {

                Empleado1 a = new Empleado1()
                {                  
                    Direccion = txbDireccion.Text,
                    Nombre = txbNombre.Text,
                    Telefono = txbTelefono.Text,
                    Correo = txbCorreo.Text,
                    Area = txbArea.Text
                };
                if (repoempleado.AgregarEmpleado(a))
                {
                    MessageBox.Show("Guardado con Éxito", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu Epleado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Empleado1 original = dtgTabla.SelectedItem as Empleado1;
                Empleado1 a = new Empleado1();
                a.Direccion = txbDireccion.Text;              
                a.Nombre = txbNombre.Text;
                a.Telefono = txbTelefono.Text;
                a.Correo = txbCorreo.Text;
                a.Area = txbArea.Text;
                if (repoempleado.ModificarEmpleado(original, a))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("Su Empleado a sido actualizado", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu Empleado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (repoempleado.LeerEmpleados().Count == 0)
            {
                MessageBox.Show("Hay un problema...", "No tienes empleados", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Empleado1 a = dtgTabla.SelectedItem as Empleado1;
                    HabilitarCajas(true);
                    txbDireccion.Text = a.Direccion;                   
                    txbNombre.Text = a.Nombre;
                    txbTelefono.Text = a.Telefono;
                    txbCorreo.Text = a.Correo;
                    txbArea.Text = a.Area;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Empleado", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(false);
            HabilitarBotones(true);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (repoempleado.LeerEmpleados().Count == 0)
            {
                MessageBox.Show("Error...", "No tienes empleado", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Empleado1 a = dtgTabla.SelectedItem as Empleado1;
                    if (MessageBox.Show("Realmente deseas eliminar a " + a.Nombre + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repoempleado.EliminarEmpleado(a))
                        { 
                            MessageBox.Show("Tu Empleado ha sido removido", "Empleado", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar a tu cEmpleado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Empleado", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
