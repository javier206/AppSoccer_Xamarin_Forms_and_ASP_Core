using Microsoft.AspNetCore.Http;
using Soccer.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Models
{
    public class TeamViewModel : Team
    {
        [DisplayName("Logo")]
        public IFormFile LogoFile { get; set; } 
    }
}
