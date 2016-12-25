using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LessMeetings.Models.StartCollaborating;

namespace LessMeetings.Models.CollaborationStatus
{
    public class CollaborationStatusViewModel
    {
        public string Title { get; set; }
        public string Goal { get; set; }
        public DateTime Deadline { get; set; }
        public List<Participant> Participants { get; set; }

        public CollaborationStatusViewModel()
        {
            Participants = new List<Participant>();
        }

        public CollaborationStatusViewModel(StartCollaboratingRequest startCollaboratingRequest)
        {
            if(startCollaboratingRequest == null) throw new ArgumentNullException(nameof(startCollaboratingRequest));

            Title = startCollaboratingRequest.Title;
            Goal = startCollaboratingRequest.Goal;
            Deadline = startCollaboratingRequest.Deadline;

            foreach (var participantInvitation in startCollaboratingRequest.ParticipantInvitations)
            {
                Participants.Add(new Participant
                {
                    Email = participantInvitation.Email,
                    Role = participantInvitation.Role,
                });
            }
        }
    }
}
