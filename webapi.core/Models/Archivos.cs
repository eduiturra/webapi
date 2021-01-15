using System;
using System.Collections.Generic;

namespace webapi.core.Models
{
       public class Archivos
    {
        public Archivos()
        {
            this.ArchivosHijos = new HashSet<Archivos>();
            this.ArchivosLog = new HashSet<ArchivosLog>();
        }
    
        public int id { get; set; }
        public string Descripcion { get; set; }
        public string Titulo { get; set; }
        public int idTipoArchivo { get; set; }
        public int Indice { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string Preview { get; set; }
        public string File { get; set; }
        public Nullable<int> idCarpeta { get; set; }
        public string Creador { get; set; }
        public bool Visible { get; set; }

        public virtual ArchivoMateriales ArchivoMateriales { get; set; }
        public virtual ArchivosTipo ArchivosTipo { get; set; }
        public virtual Archivos Carpeta { get; set; }
        public virtual ICollection<Archivos> ArchivosHijos{ get; set; }
        public virtual ICollection<ArchivosLog> ArchivosLog { get; set; }
    }
}