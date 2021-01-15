using System;

namespace webapi.core.Models
{
    public class ArchivosLog
    {
        public int id { get; set; }
        public string idUser { get; set; }
        public DateTime Fecha { get; set; }
        public int idArchivo { get; set; }
        public virtual Archivos Archivos { get; set; }
    }
}