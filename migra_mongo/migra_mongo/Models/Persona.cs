using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace migra_mongo.Models
{
   
        public class Persona
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("nome")]
            public string? Nome { get; set; }

            [BsonElement("cognome")]
            public string? Cognome { get; set; }

            [BsonElement("email")]
            public string? Email { get; set; }

            [BsonElement("telefono")]
            public string? Telefono { get; set; }

                [  BsonExtraElements]
             public BsonDocument cod_fis { get; set; } 
        
                 [BsonElement("codice")]
             public string? codice { get; set; }
        [BsonElement("datae")]
        public BsonDateTime? DataEmi{ get; set; }
        [BsonElement("dataf")]
        public BsonDateTime? DataFin { get; set; }

    }
    }
