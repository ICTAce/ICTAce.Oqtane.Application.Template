namespace SampleCompany.SampleModule;

public class ModuleInfo : IModule
{
    public ModuleDefinition ModuleDefinition => new()
    {
        Name = "SampleModule",
        Description = "Sample module",
        Version = "1.0.0",
        ServerManagerType = "SampleCompany.SampleModule.Managers.SampleModule, SampleCompany.SampleModule.Server.Oqtane",
        ReleaseVersions = "1.0.0",
        PackageName = "SampleCompany.SampleModule",
    };
}
