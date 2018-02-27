﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkLab
{
    public class MyContext : DbContext
    {
        public MyContext() : base() { }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }

        //dbsets want to map
    }
}
