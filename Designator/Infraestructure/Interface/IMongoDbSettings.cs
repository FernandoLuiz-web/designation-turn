namespace Designator.Infraestructure.Interface;

public interface IMongoDbSettings
{
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
    string DatabaseVersion { get; set; }
}
