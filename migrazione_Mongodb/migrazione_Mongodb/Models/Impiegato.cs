﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Rest_08_Mongodb.Models
{

    public class Impiegato
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("nomi")]
        public string? Nominativo { get; set; }

        [BsonElement("matr")]
        public string? Matricola { get; set; }

        [BsonElement("dipa")]
        public string? Dipartimento { get; set; }

        [BsonElement("assu")]
        //[BsonDateTimeOptions(DateOnly=true)]
        public BsonDateTime? DataAssu { get; set; }

    }
}
