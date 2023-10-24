using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class ScoreCard
    {
        public Guid PersonId {  get; set; }
        public int CompetitionId { get; set; }
        public int Score { get; set; }
    }
}
