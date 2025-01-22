﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strada.Domain.Models.Users
{
    public class UserInfo
    {
       
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        //public Address? Address { get; set; }
        //public List<Employment> Employments { get; set; }
    }
}
