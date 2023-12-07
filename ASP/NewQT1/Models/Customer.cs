using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace NewQT1.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustID { get; set; }

        public string CustName { get; set; }
        public string Address { get; set; }
    }
}
