using MongoDB.Driver;

namespace Designator.Infraestructure.Interface;

public interface IMongoDbContext
{
    IMongoCollection<T> GetCollection<T>(string collectionName);
}
