using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LessMeetings.Models.StartCollaborating
{
    public class ParticipantInvitation
    {
        [Required]
        public string Email { get; set; }

        public string Role { get; set; }
    }
}
