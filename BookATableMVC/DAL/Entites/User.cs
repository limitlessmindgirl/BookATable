﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entites
{
    public class User:BaseEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

    }
}
