﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsecticDatabaseApi.Models
{
    public class Ticket
    {
        
        [Key]
        public Guid TicketId { get; set; }
        public int Category { get; set; }
        
        public int Priority { get; set; }

        public int Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime IncidentDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string TicketDescription { get; set; }


       
        
    }
}
