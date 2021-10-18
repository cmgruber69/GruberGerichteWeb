using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruberGerichteWeb.Shared.Models
{
    public class GerichteEnum
    {
        public enum Kategorie { Vorspeise, Hauptspeise, Nachspeise, Getränke }
        public enum Zeitangebot { Frühstuck, Mittagessen, Abendessen }
        public enum Wochentage { Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }
    }
}
