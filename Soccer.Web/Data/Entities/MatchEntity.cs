using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Web.Data.Entities
{
    public class MatchEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public DateTime DateLocal => Date.ToLocalTime();
        public Team Local { get; set; }
        public Team Visitor { get; set; }
        
        [DisplayName("Goals Local")]
        public int GoalsLocal { get; set; }

        [DisplayName("Goals Visitor")]
        public int GoalsVisitor { get; set; }

        [DisplayName("Is Closed?")]
        public bool IsClosed { get; set; }

        public GroupEntity Group { get; set; }

        public ICollection<PredictionEntity> Predictions { get; set; }

    }
}
