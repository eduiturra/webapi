using System.Collections.Generic;
using webapi.core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace webapi.data.Respositories
{
        public class ArchivosRepo : RepositorioGenerico<Archivos>, IArchivosRepo
    {
        public ArchivosRepo(ApplicationDbContext db)
            : base(db)
        {

        }

        public IEnumerable<Archivos> MostrarArchivosPorCarpeta(int idCarpeta)
        {
            return FindBy(a => a.idCarpeta == idCarpeta).OrderBy(a=>a.Indice);
        }

        public Archivos DetalleArchivo(int idArchivo)
        {
            return FindBy(a=>a.id == idArchivo).FirstOrDefault();
        }

        public IEnumerable<Archivos> MostrarPorTipo(int tipo)
        {
            return FindBy(a => a.idTipoArchivo == tipo).OrderBy(a => a.Indice);
        }

        public IEnumerable<Archivos> Buscador(string buscarTexto)
        {
            return FindBy(a =>a.Visible == true && a.Titulo.Contains(buscarTexto) || a.Descripcion.Contains(buscarTexto)).OrderBy(a => a.FechaModificacion);
        }
        public IEnumerable<Archivos> CarpetasVacias()
        {
            return Context.archivos.Include(a => a.ArchivosHijos).Where(a => a.idTipoArchivo == 2 && a.ArchivosHijos.Count() == 0);
        }

        private void AumentarIndice(List<Archivos> archivos){
            foreach (var item in archivos)
            {
                var archivo = FindBy(a => a.id == item.id).FirstOrDefault();
                archivo.Indice = archivo.Indice + 1;
                Update(archivo);
            }
        }

        private void DisminuirIndice(List<Archivos> archivos)
        {
            foreach (var item in archivos)
            {
                var archivo = FindBy(a => a.id == item.id).FirstOrDefault();
                archivo.Indice = archivo.Indice - 1;
                Update(archivo);
            }
        }

    }
}