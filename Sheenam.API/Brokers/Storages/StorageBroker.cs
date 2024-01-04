using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace Sheenam.API.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        public StorageBroker()
        {
            this.Database.EnsureCreated();
        }

        public async ValueTask<T> InsertAsync<T>(T @object)
        {
            try
            {
                var broker = new StorageBroker();
                broker.Entry(@object).State = EntityState.Added;
                await broker.SaveChangesAsync();

                return @object;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source = Sheenam.db";
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlite(connectionString);
        }

        public override void Dispose() { }
    }
}
