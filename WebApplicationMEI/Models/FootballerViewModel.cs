using System.ComponentModel.DataAnnotations;

namespace WebApplicationMEI.Models
{
    public class FootballerViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field Name is empty")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field Surname is empty")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Gender is not selected")]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Field Born date is empty")]
        [RegularExpression(@"[0-9]{2}\.[0-9]{2}.[0-9]{4}", ErrorMessage = "Field Born date is uncorrect")]
        [Display(Name = "BornDate")]
        public string BornDate { get; set; }

        [Required(ErrorMessage = "Field Team name is empty")]
        [Display(Name = "TeamName")]
        public string TeamName { get; set;}

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }
    }
}
