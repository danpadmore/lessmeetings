using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LessMeetings.Models.CollaborationStatus
{
    public class Participant
    {
        public string Email { get; set; }
        public string Role { get; set; }

        public DateTime? RespondedAt { get; set; }
        public string Response { get; set; }
    }
}
