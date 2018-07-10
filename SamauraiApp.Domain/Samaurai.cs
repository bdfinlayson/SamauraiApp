using System.Collections.Generic;

namespace SamauraiApp.Domain
{
    public class Samaurai
    {
        public Samaurai()
        {
            Quotes = new List<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public int BattleId { get; set; }
    }
}
