using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore_Juan_Jacinto
{
    public class Producto
    {
        public int id;
        public string nombre;
        public string marca;
        public string descripcion;
        public float precio_base;
        public  bool descuento;
        public List<string> etiqueta;


    }
    public class Categoria:Producto
    {
        public string nombreCategoria;
    }
    public class SubCategoria : Categoria
    {
        public string nombreSubCategoria;
    }
    public class SubCategoria_Media : SubCategoria
    {
        public string nombreSubCategoria_Media;
    }
    public class SubCategoria_Baja : SubCategoria_Media
    {
        public string nombreSubCategoria_Baja;
    }
}
