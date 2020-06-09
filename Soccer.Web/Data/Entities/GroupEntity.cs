using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Web.Data.Entities
{
    public class GroupEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TournamentEntity Tournament { get; set; }
        public ICollection<GroupDetailEntity> GroupDetails { get; set; }
        public ICollection<MatchEntity> Matches { get; set; }
    }
}
