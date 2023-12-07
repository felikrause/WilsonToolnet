using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        
        public int Stock { get; set; }
        public string Img { get; set; }

        

        

        public int CategoriaId { get; set; }

        public int SubcategoriaId { get; set; }

        public int CantidadSeleccionada { get; set; }


        public Producto(int id, string name, string desc, double precio, string img,int subcategoriaid, int categoriaid, int stock)
        {
            Id = id;
            Nombre = name;
            Descripcion = desc;
            Precio = precio;
            
            Img = img;
            
            SubcategoriaId = subcategoriaid;
            CategoriaId = categoriaid;
            
            Stock = stock;

        }

        public Producto()
        {
        }


    }
}
