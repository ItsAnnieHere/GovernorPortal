using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GovernorPortal.UI.Models
{
    public class TermModel
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public int Year
        {
            get
            {
                return StartDate.Year;
            }
        }

        [Required]
        [Display(Name = "Term Type")]
        public TermType Type { get; set; }

        [Display(Name = "Current Term")]
        public static TermModel GetTerm(DateTime date)
        {
            // TODO - calculate
            return new TermModel()
                {
                    StartDate = DateTime.Parse("04 September 2011"),
                    EndDate = DateTime.Parse("02 January 2012"),
                    Type = TermType.Autumn
                };
        }
    }
}
