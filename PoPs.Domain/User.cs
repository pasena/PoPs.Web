﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoPs.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<Pop> Pops { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
    }
}
