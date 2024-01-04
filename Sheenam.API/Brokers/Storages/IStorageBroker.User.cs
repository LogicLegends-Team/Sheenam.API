using Sheenam.API.Models.Users;

namespace Sheenam.API.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
    }
}
