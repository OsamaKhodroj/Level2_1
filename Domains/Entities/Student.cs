﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Entities
{
    public class Student
    {
        public uint Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address1 { get; set; }
    }
}
