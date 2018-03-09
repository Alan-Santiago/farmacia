using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia
{
    public class RepositorioDeCliente
    {
        ManejoDeArchivos archivoCliente;
        List<Clientes1> Clientes;
        public RepositorioDeCliente()
        {
            archivoCliente = new ManejoDeArchivos("MisClientes.poo");
            Clientes = new List<Clientes1>();
        }
        public bool AgregarCliente(Clientes1 cliente)
        {
            Clientes.Add(cliente);
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }
        public bool EliminarCliente(Clientes1 cliente)
        {
            Clientes1 temporal = new Clientes1();
            foreach (var item in Clientes)
            {
                if (item.Nombre == cliente.Nombre)
                {
                    temporal = item;
                }
            }
            Clientes.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }
        public bool ModificarCliente(Clientes1 original, Clientes1 modificado)
        {
            Clientes1 temporal = new Clientes1();
            foreach (var item in Clientes)
            {
                if (original.Nombre == item.Nombre)
                {
                    temporal = item;
                }
            }
            temporal.Nombre = modificado.Nombre;
            temporal.Direccion = modificado.Direccion;
            temporal.RFC = modificado.RFC;
            temporal.Telefono = modificado.Telefono;
            temporal.Correo = modificado.Correo;
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }
        public List<Clientes1> LeerClientes()
        {
            string datos = archivoCliente.Leer();
            if (datos != null)
            {
                List<Clientes1> clientes = new List<Clientes1>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Clientes1 a = new Clientes1()
                    {
                        Nombre = campos[0],
                        Direccion = campos[1],
                        RFC = campos[2],
                        Telefono = campos[3],
                        Correo = campos[4]
                    };
                    clientes.Add(a);
                }
                Clientes = clientes;
                return clientes;
            }
            else
            {
                return null;
            }
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Clientes1 item in Clientes)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}\n", item.Nombre, item.Direccion, item.RFC, item.Telefono, item.Correo);
            }
            return archivoCliente.Guardar(datos);
        }
    }
}
