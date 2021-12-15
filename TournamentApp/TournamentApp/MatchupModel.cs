using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> entries { get; set; } = new List<MatchupEntryModel>();

        public TeamModel Winner { get; set; }

        public int matchupRound { get; set; }
    }
}
