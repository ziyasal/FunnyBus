using FunnyBus.Infrastructure.DependencyInjection;

namespace FunnyBus.Infrastructure.Configuration
{
    public interface IConfigurationContext
    {
        void SetResolver(IFunnyDependencyResolver funnyDependencyResolver);
        bool AutoScanHandlers { set; }
        bool ParallelHandlerExecution { set; }
        bool IsolatedHandlerScopes { set; }
    }
}