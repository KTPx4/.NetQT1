using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace NewQT1.Models
{
    public class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ItemID { get; set; }

        public string ItemName { get; set; }
        public string Size { get; set; }
        // Thêm các trường khác nếu cần
    }
}
