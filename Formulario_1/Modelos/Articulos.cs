using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1.Modelos
{
   public class Articulos
    {
        [Key]
        public int ArticuloId { set; get; }
        public string NombreArticulo { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
    }
}
