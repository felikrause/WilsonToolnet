using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Subcategoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public int categoria_id { get; set; }
        



        public Subcategoria(int id, string nombre, int categoriaId)
        {
            Id = id;
            Nombre = nombre;
            categoria_id = categoriaId;
   
        }

        public Subcategoria()
        {
        }
    }
}
