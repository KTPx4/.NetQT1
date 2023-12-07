using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace NewQT1.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string OrderID { get; set; }

        public DateTime OrderDate { get; set; }
        public string CustID { get; set; }
        // Thêm các trường khác nếu cần
    }
}
