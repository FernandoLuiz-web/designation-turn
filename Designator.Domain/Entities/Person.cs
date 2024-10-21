using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Designator.Domain.Entities;

public class Person
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("Roles_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public List<ObjectId> Roles { get; set; } = [];

    [BsonElement("Last_Designation")]
    public DesignationDetails? LastDesignation { get; set; }
}

public class DesignationDetails
{
    [BsonElement("Designation_Date")]
    public DateTime DesignationDate { get; set; }

    [BsonElement("Designation_id")]
    public ObjectId DesignationId { get; set; }

    [BsonElement("Is_Replaced")]
    public bool IsReplaced { get; set; }

    [BsonElement("Role_id")]
    public ObjectId RoleId { get; set; }
}