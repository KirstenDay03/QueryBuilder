using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    internal class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string series { get; set; }
        public string country { get; set; }
        public string details { get; set; }

        public BannedGame()
        {
            Id = 0;
            title = "";
            series = "";
            country = "";
            details = "";
        }

        public BannedGame(int Id, string title, string series, string country, string details)
        {
            this.Id = Id;
            this.title = title;
            this.series = series;
            this.country = country;
            this.details = details;
        }
    }
}
