using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class DanePogodowe
{
    [BsonId]
    [BsonElement("_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string ?Id { get; set; }
    public required string IdStacji { get; set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public required DateTime DataPomiaru { get; set; }
    public required string GodzinaPomiaru { get; set; }
    public required string Temperatura { get; set; }
    public required string PredkoscWiatru { get; set; }
    public required string KierunekWiatru { get; set; }
    public required string WilgotnoscWzgledna { get; set; }
    public required string SumaOpadu { get; set; }
    public required string Cisnienie { get; set; }

}