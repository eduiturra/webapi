using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Models;

namespace webapi.data.Configurations
{
    public class ArchivosConfiguration
    {
        public ArchivosConfiguration(EntityTypeBuilder<Archivos> entityBuilder)
        {
            entityBuilder.HasKey(x => x.id);
            entityBuilder.HasOne(a => a.ArchivosTipo).WithMany(a => a.Archivos).HasForeignKey(a => a.idTipoArchivo);
            entityBuilder.HasOne(a => a.Carpeta).WithMany(a => a.ArchivosHijos).HasForeignKey(a => a.idCarpeta);
            entityBuilder.HasMany(a => a.ArchivosLog).WithOne(x => x.Archivos).HasForeignKey(a => a.idArchivo);
            entityBuilder.HasOne(a => a.ArchivoMateriales).WithOne(b => b.Archivos).HasForeignKey<ArchivoMateriales>(x => x.idArchivo);
        }
        
    }
}