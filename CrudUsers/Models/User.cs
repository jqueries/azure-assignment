﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudUsers.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}