using Sheenam.API.Services.Foundations.UserServices;

namespace Sheenam.API.Services.Orchestrations
{
    public class OrchestrationService : IOrchestrationService
    {
        private readonly IUserService userService;

        public OrchestrationService(IUserService userService)
        {
            this.userService = userService;
        }


    }
}
