using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia
{
   public  class RepositorioDeEmpleado
    {
        ManejoDeArchivos archivoEmpleado;
        List<Empleado1> Empleado;
        public RepositorioDeEmpleado()
        {
            archivoEmpleado = new ManejoDeArchivos("MisEmpleados.poo");
            Empleado = new List<Empleado1>();
        }
        public bool AgregarEmpleado(Empleado1 empleado)
        {
            Empleado.Add(empleado);
            bool resultado = ActualizarArchivo();
            Empleado = LeerEmpleados();
            return resultado;
        }
        public bool EliminarEmpleado(Empleado1 empleado)
        {
            Empleado1 temporal = new Empleado1();
            foreach (var item in Empleado)
            {
                if (item.Nombre == empleado.Nombre)
                {
                    temporal = item;
                }
            }
            Empleado.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Empleado = LeerEmpleados();
            return resultado;
        }
        public bool ModificarEmpleado(Empleado1 original, Empleado1 modificado)
        {
            Empleado1 temporal = new Empleado1();
            foreach (var item in Empleado)
            {
                if (original.Nombre == item.Nombre)
                {
                    temporal = item;
                }
            }
            temporal.Nombre = modificado.Nombre;
            temporal.Correo = modificado.Correo;
            temporal.Area = modificado.Area;
            temporal.Telefono = modificado.Telefono;
            temporal.Direccion = modificado.Direccion;
            bool resultado = ActualizarArchivo();
            Empleado = LeerEmpleados();
            return resultado;
        }

        public List<Empleado1> LeerEmpleados()
        {
            string datos = archivoEmpleado.Leer();
            if (datos != null)
            {
                List<Empleado1> empleado = new List<Empleado1>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Empleado1 a = new Empleado1()
                    {
                        Nombre = campos[0],
                        Direccion = campos[1],
                        Correo = campos[2],
                        Telefono = campos[3],
                        Area = campos[4]
                    };
                    empleado.Add(a);
                }
                Empleado = empleado;
                return empleado;
            }
            else
            {
                return null;

            }
        }
        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Empleado1 item in Empleado)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}\n", item.Nombre, item.Direccion, item.Correo, item.Telefono, item.Area);
            }
            return archivoEmpleado.Guardar(datos);
        }
    }
}
