using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia
{
    public class RepositoriodeCategoria
    {
        ManejoDeArchivos archivoCategorias;
        List<Categorias1> categoria;
        public RepositoriodeCategoria()
        {
            archivoCategorias = new ManejoDeArchivos("MisCategorias.poo");
            categoria = new List<Categorias1>();
        }
        public bool AgregarCategoria(Categorias1 Categorias)
        {
            categoria.Add(Categorias);
            bool resultado = ActualizarArchivo();
            categoria = LeerCategoria();
            return resultado;
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Categorias1 item in categoria)
            {
                datos += string.Format("{0}\n", item.Nombre);
            }
            return archivoCategorias.Guardar(datos);
        }

        public bool EliminarCategoria(Categorias1 Categorias)
        {
            Categorias1 temporal = new Categorias1();
            foreach (var item in categoria)
            {
                if (item.Nombre == Categorias.Nombre)
                {
                    temporal = item;
                }
            }
            categoria.Remove(temporal);
            bool resultado = ActualizarArchivo();
            categoria = LeerCategoria();
            return resultado;
        }
        public bool ModificarCategoria(Categorias1 original, Categorias1 modificado)
        {
            Categorias1 temporal = new Categorias1();
            foreach (var item in categoria)
            {
                if (original.Nombre == item.Nombre)
                {
                    temporal = item;
                }
            }
            temporal.Nombre = modificado.Nombre;
            bool resultado = ActualizarArchivo();
            categoria = LeerCategoria();
            return resultado;
        }
        public List<Categorias1> LeerCategoria()
        {
            string datos = archivoCategorias.Leer();
            if (datos != null)
            {
                List<Categorias1> categorias = new List<Categorias1>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Categorias1 a = new Categorias1()
                    {
                        Nombre = campos[0]
                    };
                    categorias.Add(a);
                }
                categoria = categorias;
                return categorias;
            }
            else
            {
                return null;
            }
            
        }
    }
 }
        
    

