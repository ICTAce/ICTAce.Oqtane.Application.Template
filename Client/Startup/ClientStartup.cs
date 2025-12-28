using Radzen;

namespace SampleCompany.SampleModule.Client.Startup;

public class ClientStartup : IClientStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        if (!services.Any(s => s.ServiceType == typeof(ISampleModuleService)))
        {
            services.AddScoped<ISampleModuleService, SampleModuleService>();
        }

        services.AddRadzenComponents();
    }
}
