namespace SampleCompany.SampleModule.Persistence.Migrations;

[DbContext(typeof(ApplicationCommandContext))]
[Migration("ICTAce.SampleModule.01.00.00.00")]
public class InitializeModule : MultiDatabaseMigration
{
    public InitializeModule(IDatabase database) : base(database)
    {
    }

    protected override void Up(MigrationBuilder migrationBuilder)
    {
        var sampleModuleEntityBuilder = new SampleModuleEntityBuilder(migrationBuilder, ActiveDatabase);
        sampleModuleEntityBuilder.Create();
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        var sampleModuleEntityBuilder = new SampleModuleEntityBuilder(migrationBuilder, ActiveDatabase);
        sampleModuleEntityBuilder.Drop();
    }
}
