using Microsoft.EntityFrameworkCore;
using Polling.Domain;
using Polling.Repository.Interface.Common;

namespace Polling.Repository.Implementation.Common
{
    public class BaseReadOnlyRepository<TModel> : IBaseReadOnlyRepository<TModel> where TModel : RootModel
    {
        protected readonly ApplicationDbContext _context;
        public BaseReadOnlyRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public virtual async Task<TModel> GetDataAsync(Guid id)
        {
            return await _context.Set<TModel>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
