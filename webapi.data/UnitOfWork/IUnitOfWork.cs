using System.Threading.Tasks;
using webapi.data.Respositories;

namespace webapi.data.UnitOfWork
{
    public interface IUnitOfWork
    {
         IArchivosRepo ArchivosRepo {get;}
         int Complete();
         Task CompleteSync();
    }
}