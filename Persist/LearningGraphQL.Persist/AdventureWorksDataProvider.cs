
using LearningGraphQL.Persist.Contract;

namespace LearningGraphQL.Persist
{
    public class AdventureWorksDataProvider : ProviderBase<AdventureWorksDataProvider>, IAdventureWorksDataProvider
    {
        private readonly IAdventureWorksDbContext _dbContext = null!;
        public AdventureWorksDataProvider(IAdventureWorksDbContext dbContext) : base((AdventureWorksDbContext)dbContext)
            => _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

    }
}
