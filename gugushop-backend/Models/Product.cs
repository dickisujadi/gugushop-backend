using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gugushop_backend.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public bool ProductIsPublished { get; set; }
        public string ProductImage { get; set; }
        public string ProductOnlineShopLink { get; set; }
        public DateTime ProductUploadedDate { get; set; }
        public DateTime ProductModDate { get; set; }
    }
}
