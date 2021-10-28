using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Models;
using static WeAreTheChampions.Utils.EnumClass;

namespace WeAreTheChampions
{
    public class MatchDTO
    {
        public int Id { get; set; }

        public DateTime MatchTime { get; set; }

        public string MatchTimeDateText  => $"{MatchTime.ToShortDateString()}";

        public string MatchTimeHourText  => $"{MatchTime.ToString("HH:mm")}";

        public string Team1Name { get; set; }

        public string Team2Name { get; set; }

        public int? Score1 { get; set; }
        
        public int? Score2 { get; set; }

        public string ResultText => $"{(Score1 == null ? "?" : Score1.ToString()) + " - " + (Score2 == null ? "?" : Score2.ToString())}";

        public Result? Result { get; set; }
    }
}
