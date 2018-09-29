﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Entity
{
    public class User : AEntity
    {
        public string Login { get; set; }

        public string Password { get; set; }


        public string Email { get; set; }

        public string PhoneNumber { get; set; }


        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Patronymic { get; set; }

        
        public string Position { get; set; }

        public UserRole Role { get; set; } = UserRole.SLAVE;

        public IDictionary<Project, double> Projects { get; set; }
    }
}