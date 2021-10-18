using GruberGerichteWeb.Shared.Models;
using System.Collections.Generic;

namespace GruberGerichteWeb.Server.Interface
{
    public interface IGerichte
    {
        public List<Gerichte> GetAllGerichte();
        public void AddGerichte(Gerichte gerichte);
        public Gerichte GetGerichteData(string id);
        public void UpdateGerichte(Gerichte gerichte);
        public void DeleteGerichte(string id);
    }
}
