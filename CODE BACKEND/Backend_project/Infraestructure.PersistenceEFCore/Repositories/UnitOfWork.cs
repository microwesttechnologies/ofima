namespace Infraestructure.PersistenceEFCore.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        readonly SCRUMContext Context;
        public UnitOfWork(SCRUMContext context)
        {
            Context = context;
        }

        public async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
