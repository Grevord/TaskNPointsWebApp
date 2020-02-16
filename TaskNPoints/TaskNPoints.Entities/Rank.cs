using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNPoints.Entities
{
    public class Rank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Reward> RewardsOfRank { get; set; }
    }
}
