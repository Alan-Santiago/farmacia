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
    /// Lógica de interacción para cliente.xaml
    /// </summary>
    public partial class cliente : Window
    {
        RepositorioDeCliente repocliente;
        bool esNuevo;
        public cliente()
        {
            InitializeComponent();
            repocliente= new RepositorioDeCliente();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dtgTabla.ItemsSource = null;
            dtgTabla.ItemsSource = repocliente.LeerClientes();
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
            txbRFC.Clear();
            txbTelefono.Clear();
            txbCorreo.Clear();
            txbNombre.IsEnabled = habilitadas;
            txbDireccion.IsEnabled = habilitadas;
            txbRFC.IsEnabled = habilitadas;
            txbTelefono.IsEnabled = habilitadas;
            txbCorreo.IsEnabled = habilitadas;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbDireccion.Text) || string.IsNullOrEmpty(txbTelefono.Text) || string.IsNullOrEmpty(txbRFC.Text) || string.IsNullOrEmpty(txbCorreo.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {

                Clientes1 a = new Clientes1()
                {
                    RFC = txbRFC.Text,
                    Correo = txbCorreo.Text,
                    Direccion = txbDireccion.Text,
                    Nombre = txbNombre.Text,
                    Telefono = txbTelefono.Text
                };
                if (repocliente.AgregarCliente(a))
                {
                    MessageBox.Show("Guardado con Éxito", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu cliente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Clientes1 original = dtgTabla.SelectedItem as Clientes1;
                Clientes1 a = new Clientes1();
                a.RFC = txbRFC.Text;
                a.Direccion = txbDireccion.Text;
                a.Correo = txbCorreo.Text;
                a.Nombre = txbNombre.Text;
                a.Telefono = txbTelefono.Text;
                if (repocliente.ModificarCliente(original, a))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("Su cliente a sido actualizado", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu cliente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
            if (repocliente.LeerClientes().Count == 0)
            {
                MessageBox.Show("Hay un problema...", "No tienes clientes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Clientes1 a= dtgTabla.SelectedItem as Clientes1;
                    HabilitarCajas(true);
                    txbDireccion.Text = a.Direccion;
                    txbRFC.Text = a.RFC;
                    txbCorreo.Text = a.Correo;
                    txbNombre.Text = a.Nombre;
                    txbTelefono.Text = a.Telefono;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Cliente", MessageBoxButton.OK, MessageBoxImage.Question);
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
            if (repocliente.LeerClientes().Count == 0)
            {
                MessageBox.Show("Error...", "No tienes clientes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Clientes1 a = dtgTabla.SelectedItem as Clientes1;
                    if (MessageBox.Show("Realmente deseas eliminar a " + a.Nombre + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repocliente.EliminarCliente(a))
                        {
                            MessageBox.Show("Tu Cliente ha sido removido", "Cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar a tu cliente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Cliente", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
    }
}
