using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class DanePogodowe
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public required string Id { get; set; }
    public required string IdStacji { get; set; }
    public required string DataPomiaru { get; set; }
    public required string GodzinaPomiaru { get; set; }
    public required string Temperatura { get; set; }
    public required string PredkoscWiatru { get; set; }
    public required string KierunekWiatru { get; set; }
    public required string WilgotnoscWzgledna { get; set; }
    public required string SumaOpadu { get; set; }
    public required string Cisnienie { get; set; }

}