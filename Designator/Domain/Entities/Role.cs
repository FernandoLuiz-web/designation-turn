using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Designator.Domain.Entities;

public class Role
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("Observations")]
    public string Observations { get; set;} = string.Empty;
}
