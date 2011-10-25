using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace GovernorPortal.UI.Models
{
    public class MeetingModel
    {
        #region Ctor
        public MeetingModel() { }

        public MeetingModel(int meetingId)
        {
            MeetingId = meetingId;
        }
        #endregion

        [Required]
        [Display(Name = "Meeting Id")]
        public int MeetingId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Date and Time")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Committee")]
        public CommitteeModel Committee { get; set; }

        [Display(Name = "Term")]
        public TermModel Term { get; set; }
    }
}