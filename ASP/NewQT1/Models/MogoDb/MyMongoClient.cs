using MongoDB.Driver;
namespace NewQT1.Models.MogoDb
{
    public class MyMongoClient : MongoClient
    {
        public MyMongoClient(string connectionString) : base(connectionString)
        {
        }
    }
}
