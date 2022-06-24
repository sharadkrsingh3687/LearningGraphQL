using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IQueryable<TT> QueryableQuery<TT>() where TT : class
        {
            return this._context.Set<TT>().AsQueryable();
        }
    }
}
