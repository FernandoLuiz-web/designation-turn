using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Designator.Domain.Entities;

public class Designation
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public ObjectId Id { get; set; }

    [BsonElement("Designation_Date")]
    public DateTime DesignationDate { get; set; }

    [BsonElement("Role_Id")]
    public ObjectId RoleId { get; set; }

    [BsonElement("Is_Replaced")]
    public bool IsReplaced {get; set; }

    [BsonElement("Person_Id")]
    public ObjectId PersonId { get; set; }
}
