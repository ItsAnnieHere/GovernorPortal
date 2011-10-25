using System;
using System.ComponentModel.DataAnnotations;

namespace GovernorPortal.UI.Models
{
    public class CommitteeModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
