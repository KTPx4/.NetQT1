using MongoDB.Driver;
using NewQT1.Models.MogoDb;
using NewQT1.Models;

public class MyDataContext
{
    private readonly IMongoDatabase _database;

    public MyDataContext(MyMongoClient client)
    {
        _database = client.GetDatabase("QT1");
    }

    public IMongoCollection<Item> Items => _database.GetCollection<Item>("items");
    public IMongoCollection<Customer> Customer => _database.GetCollection<Customer>("customers");
}