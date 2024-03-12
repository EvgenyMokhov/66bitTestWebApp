using BusinessLogic;
using Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMEI.Models
{
    public class TeamViewModel
    {
        public string id { get; set; }
        [Required]
        [Display(Name ="TeamName")]
        public string TeamName { get; set; }
    }
}
