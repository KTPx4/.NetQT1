using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace NewQT1.Models
{
    public class OrderDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }

        public string OrderID { get; set; }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitAmount { get; set; }
    }
}
