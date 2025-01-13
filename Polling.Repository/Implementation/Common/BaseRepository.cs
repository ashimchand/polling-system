using Microsoft.EntityFrameworkCore;
using Polling.Domain;
using Polling.Repository.Interface.Common;

namespace Polling.Repository.Implementation.Common
{
    public class BaseRepository<TModel> : BaseReadOnlyRepository<TModel>, IBaseRepository<TModel> where TModel : RootModel
    {
        public BaseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public virtual async Task CreateAsync(TModel model)
        {
            try
            {
                _context.Set<TModel>().Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            try
            {
                TModel model = await _context.Set<TModel>().FirstOrDefaultAsync(x => x.Id == id);
                _context.Set<TModel>().Remove(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task ModifyAsync(TModel model)
        {
            try
            {
                _context.Set<TModel>().Update(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
