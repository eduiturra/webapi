using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.core.Models
{
    public class ArchivosTipo
    {
        public ArchivosTipo()
        {
            this.Archivos = new HashSet<Archivos>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string Tipo { get; set; }
    
        public virtual ICollection<Archivos> Archivos { get; set; }
    }
}