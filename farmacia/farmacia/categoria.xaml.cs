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
    /// Lógica de interacción para categoria.xaml
    /// </summary>
    public partial class categoria : Window
    {
        RepositoriodeCategoria repositorio;
        bool esNuevo;
        public categoria()
        {
            InitializeComponent();
            repositorio = new RepositoriodeCategoria();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dtgTabla.ItemsSource = null;
            dtgTabla.ItemsSource = repositorio.LeerCategoria();
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
            txbNombre.IsEnabled = habilitadas;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerCategoria().Count == 0)
            {
                MessageBox.Show("Error...", "No tienes Categorias", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Categorias1 a = dtgTabla.SelectedItem as Categorias1;
                    HabilitarCajas(true);
                    txbNombre.Text = a.Nombre;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Categoria", MessageBoxButton.OK, MessageBoxImage.Question);
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
            if (repositorio.LeerCategoria().Count == 0)
            {
                MessageBox.Show("Error...", "No tienes Categorias", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Categorias1 a = dtgTabla.SelectedItem as Categorias1;
                    if (MessageBox.Show("Realmente deseas eliminar a " + a.Nombre + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repositorio.EliminarCategoria(a))
                        {
                            MessageBox.Show("Tu Categoria ha sido removido", "Categoria", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar a tu Categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                        }
                    }
                }            
                else
                {
                    MessageBox.Show("¿A Quien???", "Categoria", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombre.Text)) 
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {

                Categorias1 a = new Categorias1()
                {
                    Nombre = txbNombre.Text,
                };
                if (repositorio.AgregarCategoria(a))
                {
                    MessageBox.Show("Guardado con Éxito", "Categoria", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                Categorias1 original = dtgTabla.SelectedItem as Categorias1;
                Categorias1 a = new Categorias1();
                a.Nombre = txbNombre.Text;
                if (repositorio.ModificarCategoria(original, a))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("Su Categoria a sido actualizada", "Categoria", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a tu Categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
