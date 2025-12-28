namespace SampleCompany.SampleModule.Server;

public class Program
{
    public static void Main(string[] args)
    {
        // defer server startup to Oqtane - do not modify
        var host = BuildWebHost(args);
        var databaseManager = host.Services.GetService<IDatabaseManager>();
        var install = databaseManager?.Install();
        if (install != null && !string.IsNullOrEmpty(install.Message))
        {
            var filelogger = host.Services.GetRequiredService<ILogger<Program>>();
            filelogger?.LogError("[SampleCompany.SampleModule.Server.Program.Main] {Message}", install.Message);
        }
        else
        {
            host.Run();
        }
    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseConfiguration(new ConfigurationBuilder()
                .AddCommandLine(args)
                .AddEnvironmentVariables()
                .Build())
            .UseStartup<Startup>()
            .ConfigureLocalizationSettings()
            .Build();
}
