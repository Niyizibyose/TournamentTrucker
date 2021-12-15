using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// For one team in matchup
        /// </summary>
        public TeamModel teamCompeting { get; set; }

        /// <summary>
        /// team score
        /// </summary>
        public double score { get; set; }
        public MatchupModel parentMatchup { get; set; }

        public MatchupEntryModel(double initialScore) 
        { 
            Console.WriteLine();
        }

    }
}
