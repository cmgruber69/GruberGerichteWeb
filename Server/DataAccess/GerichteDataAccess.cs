using GruberGerichteWeb.Server.Interface;
using GruberGerichteWeb.Shared.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace GruberGerichteWeb.Server.DataAccess
{
    public class GerichteDataAccess : IGerichte
    {
        private GerichteDbContext db;

        public GerichteDataAccess(GerichteDbContext _db)
        {
            db = _db;
        }

        public List<Gerichte> GetAllGerichte()
        {
            try
            {
                return db.GerichteRecords
                    .Find(x => true)
                    .ToList();
            }
            catch
            {
                throw;
            }
        }

        public Gerichte GetGerichteData(string id)
        {
            try
            {
                FilterDefinition<Gerichte> filterGerichteData = Builders<Gerichte>.Filter.Eq("Id", id);

                return db.GerichteRecords.Find(filterGerichteData).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public void AddGerichte(Gerichte gerichte)
        {
            try
            {
                db.GerichteRecords.InsertOne(gerichte);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateGerichte(Gerichte gerichte)
        {
            try
            {
                db.GerichteRecords.ReplaceOne(filter: g => g.Id == gerichte.Id, replacement: gerichte);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteGerichte(string id)
        {
            try
            {
                FilterDefinition<Gerichte> gerichteData = Builders<Gerichte>.Filter.Eq("Id", id);
                db.GerichteRecords.DeleteOne(gerichteData);
            }
            catch
            {
                throw;
            }
        }

       

        

        
    }
}
