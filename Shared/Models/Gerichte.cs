using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using static GruberGerichteWeb.Shared.Models.GerichteEnum;

namespace GruberGerichteWeb.Shared.Models
{
    public class Gerichte
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string GerichteName { get; set; }
        public string GerichteBeschreibung { get; set; }
        public double GerichtePreis { get; set; }
        //List of enum Kategorie
        public List<Kategorie> Kategorie { get; set; }

        //List of enum Zeitangebot
        public List<Zeitangebot> Zeitangebot { get; set; }

        //List of enum Wochentage
        public List<Wochentage> Wochentage { get; set; }
        public bool Ausverkauf { get; set; }

        public double Wartezeit { get; set; }
    }
}
