using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore_Juan_Jacinto
{
    public class Pedido
    {
        public int id;
        public DateTime fechaPedido;
        public List<Producto> productos;
        public int cantidad;
        public float precioFinal;
        public Usuario usuario;
    }
}
