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
    /// Lógica de interacción para producto.xaml
    /// </summary>
    public partial class producto : Window
    {
        RepositoriodeProductos repositorio;
        bool esNuevo;
        public producto()
        {
            InitializeComponent();
            repositorio = new RepositoriodeProductos();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dtgTabla.ItemsSource = null;
            dtgTabla.ItemsSource = repositorio.LeerProductos();
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
            txbDescripcion.Clear();
            txbPrecioDeCompra.Clear();
            txbPrecioDeVenta.Clear();
            txbPresentacion.Clear();
            txbCategoria.Clear();
            txbNombre.IsEnabled = habilitadas;
            txbDescripcion.IsEnabled = habilitadas;
            txbPrecioDeVenta.IsEnabled = habilitadas;
            txbPrecioDeCompra.IsEnabled = habilitadas;
            txbPresentacion.IsEnabled = habilitadas;
            txbCategoria.IsEnabled = habilitadas;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbDescripcion.Text) || string.IsNullOrEmpty(txbPrecioDeVenta.Text) || string.IsNullOrEmpty(txbPrecioDeCompra.Text) || string.IsNullOrEmpty(txbPresentacion.Text) || string.IsNullOrEmpty(txbCategoria.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {

                productos a = new productos()
                {
                    PrecioDeCompra = txbPrecioDeCompra.Text,
                    PrecioDeVenta = txbPrecioDeVenta.Text,
                    Presentacion = txbPresentacion.Text,
                    Nombre = txbNombre.Text,
                    Categoria = txbCategoria.Text,
                    Descripcion = txbDescripcion.Text
                };
                if (repositorio.AgregarProductos(a))
                {
                    MessageBox.Show("Guardado con Éxito", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {

                productos original = dtgTabla.SelectedItem as productos;
                productos a = new productos();
                a.PrecioDeCompra = txbPrecioDeCompra.Text;
                a.PrecioDeVenta = txbPrecioDeVenta.Text;
                a.Descripcion = txbDescripcion.Text;
                a.Nombre = txbNombre.Text;
                a.Presentacion = txbPresentacion.Text;
                a.Categoria = txbCategoria.Text;
                if (repositorio.ModificarProductos(original, a))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("Su producto a sido actualizado", "Producto", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu pruducto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }    
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerProductos().Count == 0)
            {
                MessageBox.Show("Hay un problema...", "No tienes productos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    productos a = dtgTabla.SelectedItem as productos;
                    HabilitarCajas(true);
                    txbPrecioDeCompra.Text = a.PrecioDeCompra;
                    txbPrecioDeVenta.Text = a.PrecioDeVenta;
                    txbPresentacion.Text = a.Presentacion;
                    txbNombre.Text = a.Nombre;
                    txbDescripcion.Text = a.Descripcion;
                    txbCategoria.Text = a.Categoria;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "producto", MessageBoxButton.OK, MessageBoxImage.Question);
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
            if (repositorio.LeerProductos().Count == 0)
            {
                MessageBox.Show("Error...", "No tienes productos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    productos a = dtgTabla.SelectedItem as productos;
                    if (MessageBox.Show("Realmente deseas eliminar a " + a.Nombre + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if(repositorio.EliminarProductos(a))
                        {
                            MessageBox.Show("Tu Producto ha sido removido", "producto", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar a tu producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "producto", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
