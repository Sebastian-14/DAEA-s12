﻿using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name = MyContextDB")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
