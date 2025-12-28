// Licensed to ICTAce under the MIT license.

namespace SampleCompany.SampleModule.Persistence;

public class ApplicationContext(
    IDBContextDependencies DBContextDependencies)
    : DBContextBase(DBContextDependencies), ITransientService, IMultiDatabase
{
    public virtual DbSet<Entities.SampleModule> SampleModule { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Entities.SampleModule>().ToTable(ActiveDatabase.RewriteName("Company_SampleModule"));
    }
}
