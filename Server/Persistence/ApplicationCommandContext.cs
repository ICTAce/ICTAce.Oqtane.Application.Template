namespace SampleCompany.SampleModule.Persistence;

public class ApplicationCommandContext(
    IDBContextDependencies DBContextDependencies)
    : ApplicationContext(DBContextDependencies);
