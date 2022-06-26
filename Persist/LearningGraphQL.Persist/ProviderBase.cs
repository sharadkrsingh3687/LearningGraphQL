using Microsoft.EntityFrameworkCore;

namespace LearningGraphQL.Persist
{
    public abstract class ProviderBase<T> where T : class
    {
        protected readonly DbContext _context;

        public ProviderBase(DbContext dbContext)
        {
            this._context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this._context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<IEnumerable<TT>> GetListDataAsync<TT>(CancellationToken cancellationToken) where TT : class
            => await this._context.Set<TT>().ToListAsync(cancellationToken).ConfigureAwait(false);
        
    }
}
