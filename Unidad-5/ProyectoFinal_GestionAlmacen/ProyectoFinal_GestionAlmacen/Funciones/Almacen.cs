using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_GestionAlmacen.Funciones
{
    public static class Almacen
    {
        // Diccionario ID|Producto
        public static Dictionary<string, Producto> Productos = new Dictionary<string, Producto>();
    }

    public class Producto
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Necesidad { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        public string ITBIS { get; set; }
        public string PrecioTotal { get; set; }
        public string CantidadMinima { get; set; }
        public string Estado { get; set; }
    }

}
