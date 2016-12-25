using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LessMeetings.Models.StartCollaborating
{
    public class StartCollaboratingRequest
    {
        [Required]
        public string Goal { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        public List<ParticipantInvitation> ParticipantInvitations { get; set; }

        public StartCollaboratingRequest()
        {
            ParticipantInvitations = new List<ParticipantInvitation>();
        }
    }
}
