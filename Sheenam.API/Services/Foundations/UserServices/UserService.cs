using Sheenam.API.Brokers.Storages;
using Sheenam.API.Models.Users;

namespace Sheenam.API.Services.Foundations.UserServices
{
    public class UserService : IUserService
    {
        private readonly IStorageBroker storageBroker;

        public UserService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.storageBroker.InsertUserAsync(user);

        public IQueryable<User> RetrieveAllUsers() =>
            this.storageBroker.SelectAllUsers();

        public async ValueTask<User> RetrieveUserByIdAsync(Guid id) =>
            await this.storageBroker.SelectUserByIdAsync(id);

        public async ValueTask<User> ModifyUserAsync(User user) =>
            await this.storageBroker.UpdateUserAsync(user);

        public async ValueTask<User> RemoveUserAsync(Guid id)
        {
            User maybeUser =
                await this.storageBroker.SelectUserByIdAsync(id);

            return await this.storageBroker.DeleteUserAsync(maybeUser);
        }
    }
}
