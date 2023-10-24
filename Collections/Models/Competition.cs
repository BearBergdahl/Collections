using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class Competition
    {
        public int CompetitionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Person Winner { get; set; }
        public ArrayList Participants { get; set; }     
    }
}
