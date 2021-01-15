using System.Threading.Tasks;
using webapi.data.Respositories;

namespace webapi.data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext _context{get;set;}
        public IArchivosRepo ArchivosRepo {get;}
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ArchivosRepo = new ArchivosRepo(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public Task CompleteSync()
        {
            return _context.SaveChangesAsync();
        }
    }
}