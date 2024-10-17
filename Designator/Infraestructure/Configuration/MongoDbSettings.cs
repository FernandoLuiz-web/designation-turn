using Designator.Infraestructure.Interface;

namespace Designator.Infraestructure.Configuration;

public class MongoDbSettings : IMongoDbSettings
{
    public string ConnectionString {get; set;} = string.Empty;

    public string DatabaseName {get; set;} = string.Empty;

    public string DatabaseVersion {get; set;} = string.Empty;
}
