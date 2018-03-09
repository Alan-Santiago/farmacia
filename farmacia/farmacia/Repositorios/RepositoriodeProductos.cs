using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia
{
    public class RepositoriodeProductos
    {
        ManejoDeArchivos archivoProductos;
        List<productos> Producto;
        public RepositoriodeProductos()
        {
            archivoProductos = new ManejoDeArchivos("MisProductos.poo");
           Producto = new List<productos>();
        }
        public bool AgregarProductos(productos Productos)
        {
            Producto.Add(Productos);
            bool resultado = ActualizarArchivo();
            Producto = LeerProductos();
            return resultado;
        }
        public bool EliminarProductos(productos Productos)
        {
            productos temporal = new productos();
            foreach (var item in Producto)
            {
                if (item.Nombre == Productos.Nombre)
                {
                    temporal = item;
                }
            }
            Producto.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Producto = LeerProductos();
            return resultado;
        }
        public bool ModificarProductos(productos original, productos modificado)
        {
            productos temporal = new productos();
            foreach (var item in Producto)
            {
                if (original.Nombre == item.Nombre)
                {
                    temporal = item;
                }
            }
            temporal.Nombre = modificado.Nombre;
            temporal.Descripcion = modificado.Descripcion;
            temporal.PrecioDeCompra = modificado.PrecioDeCompra;
            temporal.PrecioDeVenta = modificado.PrecioDeVenta;
            temporal.Presentacion = modificado.Presentacion;
            temporal.Categoria = modificado.Categoria;
            bool resultado = ActualizarArchivo();
            Producto = LeerProductos();
            return resultado;
        }
        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (productos item in Producto)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}|{5}\n", item.Nombre, item.Descripcion, item.PrecioDeCompra, item.PrecioDeVenta, item.Presentacion, item.Categoria);
            }
            return archivoProductos.Guardar(datos);
        }
        public List<productos> LeerProductos()
        {
            string datos = archivoProductos.Leer();
            if (datos != null)
            {
                List<productos> Productos = new List<productos>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    productos a = new productos()
                    {
                        Nombre = campos[0],
                        Descripcion = campos[1],
                        PrecioDeCompra = campos[2],
                        PrecioDeVenta= campos[3],
                        Presentacion = campos[4],
                        Categoria = campos[5]
                    };
                    Productos.Add(a);
                }
                Producto = Productos;
                return Productos;
            }
            else
            {
                return null;
            }
        }
        
    }
}
