using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

public class DanePogodoweRepozytorium
{
    private readonly IMongoCollection<DanePogodowe>? _danePogodowe;

    public DanePogodoweRepozytorium(IConfiguration config)
    {
        var connectionString = config.GetConnectionString("MongoSettings");
        var databaseName = config["DatabaseName"];
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        _danePogodowe = database.GetCollection<DanePogodowe>("dane");
    }

    //Read - pobieranie danych z MongoDB
    public List<DanePogodowe> Get()
    {
        return _danePogodowe.Find(danePogodowe => true).ToList();
    }

    public List<DanePogodowe> Get(string startDate, string endDate)
    {
        return _danePogodowe.Find(danePogodowe => true).ToList();
    }
    //ReadOne - Pobierz jednego po _id
    // public DanePogodowe Get(string id)
    // {
    //     return _danePogodowe.Find<DanePogodowe>(danePogodowe => danePogodowe.Id == id).FirstOrDefault();
    // }
    //InsertOne - Dodaj jeden rekord
    public DanePogodowe Create(DanePogodowe danePogodowe)
    {
        if (_danePogodowe != null)
        {
            _danePogodowe.InsertOne(danePogodowe);
        }
        return danePogodowe;
    }
}