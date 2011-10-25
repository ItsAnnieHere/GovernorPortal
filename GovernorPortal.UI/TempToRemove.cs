using System;
using System.Collections.ObjectModel;
using GovernorPortal.UI.Models;

namespace GovernorPortal.UI
{
    public class TempToRemove
    {
        public static MeetingModel GetMeeting()
        {
            return new MeetingModel()
         {
             MeetingId = 1,
             Title = "Full Governing Body",
             DateTime = DateTime.Now.AddDays(50),
             Term = new TermModel()
                {
                    StartDate = DateTime.Parse("04 September 2011"),
                    EndDate = DateTime.Parse("02 January 2012"),
                    Type = TermType.Autumn
                }
         };
        }

        public static Collection<MeetingModel> GetMeetings()
        {
            var meetings = new Collection<MeetingModel>()
        {
         new MeetingModel()
         {
             MeetingId = 1,
             Title = "Full Governing Body",
             DateTime = DateTime.Now.AddDays(50),
             Term = new TermModel()
                {
                    StartDate = DateTime.Parse("04 September 2011"),
                    EndDate = DateTime.Parse("02 January 2012"),
                    Type = TermType.Autumn
                }
         },
         new MeetingModel()
         {
             MeetingId = 2,
             Title = "Corporate Services",
             DateTime = DateTime.Now.AddDays(25),
             Committee = new CommitteeModel()
             {
                 Name = "Corporate Services"
             },
             Term = new TermModel()
                {
                    StartDate = DateTime.Parse("04 September 2011"),
                    EndDate = DateTime.Parse("02 January 2012"),
                    Type = TermType.Autumn
                }
         } 
        };
            return meetings;
        }
    }
}