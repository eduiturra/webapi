using System.ComponentModel.DataAnnotations;

namespace webapi.core.Models
{
    public class ArchivoMateriales
    {
        [Key]
        public int idArchivo { get; set; }
        public string Path { get; set; }

        public virtual Archivos Archivos { get; set; }
    }
}