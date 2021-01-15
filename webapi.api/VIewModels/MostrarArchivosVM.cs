using System;

namespace webapi.api.VIewModels
{
    public class MostrarArchivosVM
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public string Titulo { get; set; }
        public int idTipoArchivo { get; set; }
        public int Indice { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int idPestañas { get; set; }
        public string Preview { get; set; }
        public string File { get; set; }
        public Nullable<int> idCarpeta { get; set; }
        public string Creador { get; set; }
        public bool Visible { get; set; }
    }
}