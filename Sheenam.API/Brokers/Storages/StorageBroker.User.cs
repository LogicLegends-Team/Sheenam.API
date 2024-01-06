using Microsoft.EntityFrameworkCore;
using Sheenam.API.Models.Users;

namespace Sheenam.API.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }

        public async ValueTask<User> InsertUserAsync(User user) =>
            await InsertAsync(user);

        public IQueryable<User> SelectAllUsers() =>
            SelectAll<User>().AsQueryable();

        public async ValueTask<User> SelectUserByIdAsync(Guid id) =>
            await SelectAsync<User>(id);
    }
}