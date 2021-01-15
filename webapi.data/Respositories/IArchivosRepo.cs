using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.core.Models;

namespace webapi.data.Respositories
{
    public interface IArchivosRepo: IRepositorioGenerico<Archivos>
    {
        IEnumerable<Archivos> MostrarArchivosPorCarpeta(int idCarpeta);
        Archivos DetalleArchivo(int idArchivo);
        IEnumerable<Archivos> MostrarPorTipo(int tipo);
        IEnumerable<Archivos> Buscador(string buscarTexto);
        IEnumerable<Archivos> CarpetasVacias();
    }
}
