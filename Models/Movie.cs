using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [BsonElement("Genre")]
        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Genre { get; set; }

        [BsonElement("ReleaseDate")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}