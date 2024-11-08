﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Rest_08_Mongodb.Models
{

    public class ImpiegatoDTO
    {


        [Required]
        [StringLength(100)]
        public string? Nom { get; set; }

        [Required]
        [StringLength(10)]
        public string? Mat { get; set; }

        [Required]
        [StringLength(100)]
        public string? Dip { get; set; }


        [Required]
         
        public DateTime Dat{ get; set; }

    }
}
