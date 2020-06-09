using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Web.Data.Entities
{
    public class TournamentEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "yyyy/MM/dd", ApplyFormatInEditMode =false)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "yyyy/MM/dd", ApplyFormatInEditMode = false)]
        public DateTime StartDateLocal => StartDate.ToLocalTime();

        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDateLocal => EndDate.ToLocalTime();

        [DisplayName("Is Active?")]
        public bool IsActive { get; set; }

        [DisplayName("Logo")]
        public string LogoPath { get; set; }

        public ICollection<GroupEntity> Groups { get; set; }
    }
}
