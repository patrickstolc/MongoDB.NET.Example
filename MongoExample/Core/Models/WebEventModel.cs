using MongoDB.Bson;

namespace MongoExample.Core.Models;

public class WebEventModel
{
    public ObjectId _id { get; set; }
    public DateTime Timestamp { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public Dictionary<string, string> payload { get; set; }
}